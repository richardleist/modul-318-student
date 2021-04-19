using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Device.Location;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransportApp
{
    public partial class SwissInterface : Form
    {

        ITransport transportApi = new Transport();
        List<Connection> latestConnections = new List<Connection>();

        public SwissInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get StationObj by name
        /// </summary>
        /// <param name="name">Name of Station</param>
        /// <returns>StationObj</returns>
        private Stations GetStationsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            return transportApi.GetStations(name);
        }

        /// <summary>
        /// Get Details and Departures of Station
        /// </summary>
        /// <param name="stationName">Name of Station</param>
        /// <param name="stationID">ID of Station</param>
        /// <returns>List of StationBoards</returns>
        private List<StationBoard> GetStationBoard(string stationName, string stationID)
        {
            if (stationName is null)
            {
                throw new ArgumentNullException(nameof(stationName));
            }

            if (stationID is null)
            {
                throw new ArgumentNullException(nameof(stationID));
            }

            StationBoardRoot root = transportApi.GetStationBoard(stationName, stationID);

            if (root == null)
                return null;
            return root.Entries;
        }

        /// <summary>
        /// Returns the ID of a Station
        /// </summary>
        /// <param name="name">Name of a Station</param>
        /// <returns>ID of Station</returns>
        private string GetStationIDByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            List<Station> listOfStations = transportApi.GetStations(name).StationList;
            foreach (Station station in listOfStations)
            {
                return station.Id;
            }
            return null;
        }

        /// <summary>
        /// Get Connections between Stations at a Time
        /// </summary>
        /// <param name="station1">Station to start from</param>
        /// <param name="station2">Station to finish the Travel</param>
        /// <param name="dateTime">Starttime of the Travel</param>
        /// <returns>Connections</returns>
        private Connections GetConnectionsByStations(string station1, string station2, DateTime dateTime)
        {
            if (station1 is null)
            {
                throw new ArgumentNullException(nameof(station1));
            }

            if (station2 is null)
            {
                throw new ArgumentNullException(nameof(station2));
            }

            if(dateTime == null)
            {
                throw new ArgumentNullException(nameof(dateTime));
            }

            Connections connections = transportApi.GetConnections(station1, station2, dateTime);
            if (connections == null)
                return null;
            return connections;
        }

        /// <summary>
        /// Gets Names of Stations
        /// </summary>
        /// <param name="stations">Stations from which the name is returned</param>
        /// <returns>StationsNames</returns>
        private string[] GetStationNamesByStations(List<Station> stations)
        {
            if (stations == null)
            {
                throw new ArgumentNullException(nameof(stations));
            }

            if (stations.Count <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(stations));
            }

            List<string> stationNames = new List<string>();
            foreach (Station station in stations)
            {
                stationNames.Add(station.Name);
            }
            return stationNames.ToArray();
        }

        private void SwissInterface_Load(object sender, EventArgs e)
        {
            dateTimeTripStart.Value = DateTime.Now;
        }

        /// <summary>
        /// Sends an Mail with Connection-Details
        /// </summary>
        /// <param name="mailAddress">Mail Address to send the Mail to</param>
        /// <param name="connection">Connection to send</param>
        private void SendConnectionMail(string mailAddress, Connection connection)
        {
            if (string.IsNullOrEmpty(mailAddress))
            {
                throw new ArgumentNullException(nameof(mailAddress));
            }

            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }

            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "mytransportapp.notify@gmail.com",
                    Password = "H#7nF!4FRFNzvc3W9$d*!DB22Pg7^zQG"
                }
            };
            MailAddress FromEmail = new MailAddress("mytransportapp.notify@gmail.com", "MyTransportApp");

            string bodyHtml = "<table border=2><tr><th>Abfahrt</th><th>Ankunft</th><th>Gleis</th><th>Start</th><th>Ziel</th><th>Fahrtzeit</th></tr>"
                    + "<tr><td>" + connection.From.Departure + "</td>"
                    + "<td>" + connection.To.Arrival + "</td>"
                    + "<td>" + connection.From.Platform + "</td>"
                    + "<td>" + connection.From.Station.Name + "</td>"
                    + "<td>" + connection.To.Station.Name + "</td>"
                    + "<td>" + connection.Duration.Substring(3, 5) + " Minuten" + "</td></tr></table>";

            try
            {
                MailAddress ToEmail = new MailAddress(mailAddress);
                MailMessage Message = new MailMessage()
                {
                    From = FromEmail,
                    Subject = "Bahnverbindung",
                    Body = "Ich habe folgende Bahn-Verbindung gefunden: <br>" + bodyHtml,
                };
                Message.IsBodyHtml = true;
                Message.To.Add(ToEmail);
                Client.SendCompleted += Client_SendCompleted;
                Client.SendMailAsync(Message);
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Opens MessageBox with MailSendResult
        /// </summary>
        /// <param name="sender">MailSender</param>
        /// <param name="e">Results of MailSending</param>
        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Versandt fehlgeschlagen: \n" + e.Error.Message, "");
                return;
            }
            MessageBox.Show("Email wurde gesendet!");
        }

        /// <summary>
        /// Close Application
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Change colors to LightMode
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lightModeToolStripMenuItem.Checked = true;
            darkModeToolStripMenuItem.Checked = false;
            this.BackColor = System.Drawing.SystemColors.Control;
            tabPageSingleStation.BackColor = System.Drawing.Color.White;
            tabPageTravel.BackColor = System.Drawing.Color.White;
            groupBoxDeparture.ForeColor = System.Drawing.Color.Black;
            groupBoxArrivals.ForeColor = System.Drawing.Color.Black;
            groupBoxConnections.ForeColor = System.Drawing.Color.Black;
            groupBoxSingleStation.ForeColor = System.Drawing.Color.Black;
            groupBoxDepartures.ForeColor = System.Drawing.Color.Black;
        }

        /// <summary>
        /// Change colors to DarkMode
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lightModeToolStripMenuItem.Checked = false;
            darkModeToolStripMenuItem.Checked = true;

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2f2f30");
            tabPageSingleStation.BackColor = System.Drawing.ColorTranslator.FromHtml("#2f2f30");
            tabPageTravel.BackColor = System.Drawing.ColorTranslator.FromHtml("#2f2f30");
            groupBoxDeparture.ForeColor = System.Drawing.ColorTranslator.FromHtml("#fcfcfc");
            groupBoxArrivals.ForeColor = System.Drawing.ColorTranslator.FromHtml("#fcfcfc");
            groupBoxConnections.ForeColor = System.Drawing.ColorTranslator.FromHtml("#fcfcfc");
            groupBoxSingleStation.ForeColor = System.Drawing.ColorTranslator.FromHtml("#fcfcfc");
            groupBoxDepartures.ForeColor = System.Drawing.ColorTranslator.FromHtml("#fcfcfc");
            btnSearchSingleStation.ForeColor = System.Drawing.Color.Black;
            btnShowDepartures.ForeColor = System.Drawing.Color.Black;
            btnShowNearestStations.ForeColor = System.Drawing.Color.Black;
            btnShowStationOnMap.ForeColor = System.Drawing.Color.Black;
            dataGridViewDepartures.ForeColor = System.Drawing.Color.Black;
            dataGridViewConnections.ForeColor = System.Drawing.Color.Black;
        }

        private void btnSearchSingleStation_Click(object sender, EventArgs e)
        {
            if(textBoxSingleStation.Text.Length > 3)
            {
                dataGridViewDepartures.Rows.Clear();

                string stationId = GetStationIDByName(textBoxSingleStation.Text);

                if (string.IsNullOrEmpty(stationId))
                {
                    throw new ArgumentOutOfRangeException(nameof(stationId));
                }

                List<StationBoard> stationBoards = GetStationBoard(textBoxSingleStation.Text, stationId);
                foreach (StationBoard stationBoard in stationBoards)
                {
                    try
                    {
                        dataGridViewDepartures.Rows.Add(Convert.ToDateTime(stationBoard.Stop.Departure).ToShortTimeString(), stationBoard.Name, stationBoard.To);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                dataGridViewDepartures.Refresh();
            }
        }

        /// <summary>
        /// Call UpdateSingleStations
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of TextChangeEvent</param>
        private void textBoxSingleStation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSingleStation.Text.Length > 0)
            {
                UpdateSingleStations();
            }
        }

        /// <summary>
        /// Update Station1 ListBox
        /// </summary>
        private void UpdateSingleStations()
        {
            List<Station> stations = GetStationsByName(textBoxSingleStation.Text).StationList;
            listBoxSingleStation.DataSource = stations;
            listBoxSingleStation.DisplayMember = "Name";
        }

        /// <summary>
        /// Select Item of ListBox
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void listBoxSingleStation_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxSingleStation.Text = ((SwissTransport.Models.Station)listBoxSingleStation.SelectedItem).Name;
                UpdateSingleStations();
            }
            catch{}
        }

        /// <summary>
        /// Get Connections at Time from Station1 to Station2 / List Connections in dataGrid
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void btnShowDepartures_Click(object sender, EventArgs e)
        {
            if((textBoxStation1.Text.Length > 3) && (textBoxStation2.Text.Length > 3))
            {
                dataGridViewConnections.Rows.Clear();
                latestConnections.Clear();

                List<Connection> connections = GetConnectionsByStations(textBoxStation1.Text, textBoxStation2.Text, dateTimeTripStart.Value).ConnectionList;
                foreach (Connection connection in connections)
                {
                    try
                    {
                        latestConnections.Add(connection);
                        dataGridViewConnections.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToShortTimeString(),
                                                        Convert.ToDateTime(connection.To.Arrival).ToShortTimeString(),
                                                        connection.From.Platform,
                                                        connection.From.Station.Name,
                                                        connection.To.Station.Name,
                                                        connection.Duration.Substring(3, 5));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                dataGridViewConnections.Refresh();
            }
        }

        /// <summary>
        /// Call UpdateTripStation1ListBox
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of TextChangeEvent</param>
        private void textBoxStation1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStation1.Text.Length > 0)
            {
                UpdateTripStation1ListBox();
            }
        }

        /// <summary>
        /// Update Station1 ListBox
        /// </summary>
        private void UpdateTripStation1ListBox()
        {
            List<Station> stations = GetStationsByName(textBoxStation1.Text).StationList;
            listBoxTripStation1.DataSource = stations;
            listBoxTripStation1.DisplayMember = "Name";
        }

        /// <summary>
        /// Select Item of ListBox
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void listBoxTripStation1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxStation1.Text = ((SwissTransport.Models.Station)listBoxTripStation1.SelectedItem).Name;
                UpdateTripStation1ListBox();
            }
            catch{}
        }

        /// <summary>
        /// Call UpdateTripStation2ListBox
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of TextChangeEvent</param>
        private void textBoxStation2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStation2.Text.Length > 0)
            {
                UpdateTripStation2ListBox();
            }
        }

        /// <summary>
        /// Update Station2 ListBox
        /// </summary>
        private void UpdateTripStation2ListBox()
        {
            List<Station> stations = GetStationsByName(textBoxStation2.Text).StationList;
            listBoxTripStation2.DataSource = stations;
            listBoxTripStation2.DisplayMember = "Name";
        }
        /// <summary>
        /// Select Item of ListBox
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void listBoxTripStation2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxStation2.Text = ((SwissTransport.Models.Station)listBoxTripStation2.SelectedItem).Name;
                UpdateTripStation2ListBox();
            }
            catch{}
        }

        /// <summary>
        /// Promting E-Mail Input / Sending Mail with Connection-Information
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void dataGridViewConnections_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewConnections.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    MenuItem sendAsMailButton = new MenuItem("Verbindung per E-Mail senden");
                    sendAsMailButton.Click += new EventHandler((object snd, EventArgs args) => {
                        InputMailAddress inputMailAddress = new InputMailAddress();
                        inputMailAddress.ShowDialog(this);
                        if(inputMailAddress.textBoxEnterMailInput.Text != null)
                        {
                            SendConnectionMail(inputMailAddress.textBoxEnterMailInput.Text, latestConnections[currentMouseOverRow]);
                        }
                        inputMailAddress.Dispose();
                    });
                    m.MenuItems.Add(sendAsMailButton);
                    m.Show(dataGridViewConnections, new Point(e.X, e.Y));
                }
            }
        }

        /// <summary>
        /// Open Station-Map-View in Browser
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void btnShowStationOnMap_Click(object sender, EventArgs e)
        {
            if(textBoxSingleStation.Text.Length > 3)
            {
                Station station = ((SwissTransport.Models.Station)listBoxSingleStation.SelectedItem);
                var x = station.Coordinate.XCoordinate.ToString("0.0000000", System.Globalization.CultureInfo.InvariantCulture);
                var y = station.Coordinate.YCoordinate.ToString("0.0000000", System.Globalization.CultureInfo.InvariantCulture);
                System.Diagnostics.Process.Start("http://maps.google.com/maps?q=" + x + "," + y + "&ll=" + x + "," + y + "&z=15");
            }
        }

        /// <summary>
        /// List nearest Stations of current coordinates
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of ClickEvent</param>
        private void btnShowNearestStations_Click(object sender, EventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(100));
            GeoCoordinate coordinate = watcher.Position.Location;
            if (coordinate.IsUnknown != true)
            {
                List<Station> stations = transportApi.GetStationsByCoords(coordinate.Latitude, coordinate.Longitude).StationList;
                listBoxSingleStation.DataSource = stations;
                listBoxSingleStation.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Die Koordinaten konnten nicht ermittelt werden!");
            }
        }

        /// <summary>
        /// Selects current Item and changes selected Item
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of KeyEvent</param>
        private void textBoxSingleStation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                        textBoxSingleStation.Text = ((SwissTransport.Models.Station)listBoxSingleStation.SelectedItem).Name;
                        UpdateSingleStations();
                }
                else if(e.KeyCode == Keys.Up)
                {
                    if(listBoxSingleStation.SelectedIndex > 0)
                    {
                        listBoxSingleStation.SelectedIndex = listBoxSingleStation.SelectedIndex - 1;
                        e.Handled = true;
                    }
                }
                else if(e.KeyCode == Keys.Down)
                {
                    if(listBoxSingleStation.SelectedIndex < (listBoxSingleStation.Items.Count - 1))
                    {
                        listBoxSingleStation.SelectedIndex = listBoxSingleStation.SelectedIndex + 1;
                        e.Handled = true;
                    }
                }
            }
            catch {}
        }

        /// <summary>
        /// Selects current Item and changes selected Item
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of KeyEvent</param>
        private void textBoxStation1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxStation1.Text = ((SwissTransport.Models.Station)listBoxTripStation1.SelectedItem).Name;
                    UpdateSingleStations();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (listBoxTripStation1.SelectedIndex > 0)
                    {
                        listBoxTripStation1.SelectedIndex = listBoxTripStation1.SelectedIndex - 1;
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (listBoxTripStation1.SelectedIndex < (listBoxTripStation1.Items.Count - 1))
                    {
                        listBoxTripStation1.SelectedIndex = listBoxTripStation1.SelectedIndex + 1;
                        e.Handled = true;
                    }
                }
            }
            catch {}
        }

        /// <summary>
        /// Selects current Item and changes selected Item
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of KeyEvent</param>
        private void textBoxStation2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxStation2.Text = ((SwissTransport.Models.Station)listBoxTripStation2.SelectedItem).Name;
                    UpdateSingleStations();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (listBoxTripStation2.SelectedIndex > 0)
                    {
                        listBoxTripStation2.SelectedIndex = listBoxTripStation2.SelectedIndex - 1;
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (listBoxTripStation2.SelectedIndex < (listBoxTripStation2.Items.Count - 1))
                    {
                        listBoxTripStation2.SelectedIndex = listBoxTripStation2.SelectedIndex + 1;
                        e.Handled = true;
                    }
                }
            }
            catch {}
        }

        /// <summary>
        /// Selects current Item and changes selected Item
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of KeyEvent</param>
        private void listBoxSingleStation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxSingleStation.Text = ((SwissTransport.Models.Station)listBoxSingleStation.SelectedItem).Name;
                    UpdateSingleStations();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (listBoxSingleStation.SelectedIndex > 0)
                    {
                        listBoxSingleStation.SelectedIndex = listBoxSingleStation.SelectedIndex - 1;
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (listBoxSingleStation.SelectedIndex < (listBoxSingleStation.Items.Count - 1))
                    {
                        listBoxSingleStation.SelectedIndex = listBoxSingleStation.SelectedIndex + 1;
                        e.Handled = true;
                    }
                }
            }
            catch {}
        }

        /// <summary>
        /// Selects current Item and changes selected Item
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of KeyEvent</param>
        private void listBoxTripStation1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxStation1.Text = ((SwissTransport.Models.Station)listBoxTripStation1.SelectedItem).Name;
                    UpdateSingleStations();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (listBoxTripStation1.SelectedIndex > 0)
                    {
                        listBoxTripStation1.SelectedIndex = listBoxTripStation1.SelectedIndex - 1;
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (listBoxTripStation1.SelectedIndex < (listBoxTripStation1.Items.Count - 1))
                    {
                        listBoxTripStation1.SelectedIndex = listBoxTripStation1.SelectedIndex + 1;
                        e.Handled = true;
                    }
                }
            }
            catch {}
        }

        /// <summary>
        /// Selects current Item and changes selected Item
        /// </summary>
        /// <param name="sender">View of Form</param>
        /// <param name="e">Arguments of KeyEvent</param>
        private void listBoxTripStation2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxStation2.Text = ((SwissTransport.Models.Station)listBoxTripStation2.SelectedItem).Name;
                    UpdateSingleStations();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (listBoxTripStation2.SelectedIndex > 0)
                    {
                        listBoxTripStation2.SelectedIndex = listBoxTripStation2.SelectedIndex - 1;
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (listBoxTripStation2.SelectedIndex < (listBoxTripStation2.Items.Count - 1))
                    {
                        listBoxTripStation2.SelectedIndex = listBoxTripStation2.SelectedIndex + 1;
                        e.Handled = true;
                    }
                }
            }
            catch {}
        }
    }
}