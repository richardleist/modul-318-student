using System;

namespace MyTransportApp
{
    partial class SwissInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlSwissInterface = new System.Windows.Forms.TabControl();
            this.tabPageSingleStation = new System.Windows.Forms.TabPage();
            this.groupBoxSingleStation = new System.Windows.Forms.GroupBox();
            this.btnShowNearestStations = new System.Windows.Forms.Button();
            this.btnShowStationOnMap = new System.Windows.Forms.Button();
            this.listBoxSingleStation = new System.Windows.Forms.ListBox();
            this.btnSearchSingleStation = new System.Windows.Forms.Button();
            this.textBoxSingleStation = new System.Windows.Forms.TextBox();
            this.groupBoxDepartures = new System.Windows.Forms.GroupBox();
            this.dataGridViewDepartures = new System.Windows.Forms.DataGridView();
            this.columnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTravel = new System.Windows.Forms.TabPage();
            this.btnShowDepartures = new System.Windows.Forms.Button();
            this.groupBoxArrivals = new System.Windows.Forms.GroupBox();
            this.listBoxTripStation2 = new System.Windows.Forms.ListBox();
            this.textBoxStation2 = new System.Windows.Forms.TextBox();
            this.groupBoxDeparture = new System.Windows.Forms.GroupBox();
            this.dateTimeTripStart = new System.Windows.Forms.DateTimePicker();
            this.listBoxTripStation1 = new System.Windows.Forms.ListBox();
            this.textBoxStation1 = new System.Windows.Forms.TextBox();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
            this.columnTripDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTripEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTripPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTripStartStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTripEndStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTripTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anwendungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSwissInterface.SuspendLayout();
            this.tabPageSingleStation.SuspendLayout();
            this.groupBoxSingleStation.SuspendLayout();
            this.groupBoxDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).BeginInit();
            this.tabPageTravel.SuspendLayout();
            this.groupBoxArrivals.SuspendLayout();
            this.groupBoxDeparture.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSwissInterface
            // 
            this.tabControlSwissInterface.Controls.Add(this.tabPageSingleStation);
            this.tabControlSwissInterface.Controls.Add(this.tabPageTravel);
            this.tabControlSwissInterface.Location = new System.Drawing.Point(12, 27);
            this.tabControlSwissInterface.Name = "tabControlSwissInterface";
            this.tabControlSwissInterface.SelectedIndex = 0;
            this.tabControlSwissInterface.Size = new System.Drawing.Size(910, 507);
            this.tabControlSwissInterface.TabIndex = 0;
            // 
            // tabPageSingleStation
            // 
            this.tabPageSingleStation.Controls.Add(this.groupBoxSingleStation);
            this.tabPageSingleStation.Controls.Add(this.groupBoxDepartures);
            this.tabPageSingleStation.Location = new System.Drawing.Point(4, 22);
            this.tabPageSingleStation.Name = "tabPageSingleStation";
            this.tabPageSingleStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingleStation.Size = new System.Drawing.Size(902, 481);
            this.tabPageSingleStation.TabIndex = 0;
            this.tabPageSingleStation.Text = "Einzelne Station";
            this.tabPageSingleStation.UseVisualStyleBackColor = true;
            // 
            // groupBoxSingleStation
            // 
            this.groupBoxSingleStation.Controls.Add(this.btnShowNearestStations);
            this.groupBoxSingleStation.Controls.Add(this.btnShowStationOnMap);
            this.groupBoxSingleStation.Controls.Add(this.listBoxSingleStation);
            this.groupBoxSingleStation.Controls.Add(this.btnSearchSingleStation);
            this.groupBoxSingleStation.Controls.Add(this.textBoxSingleStation);
            this.groupBoxSingleStation.Location = new System.Drawing.Point(298, 6);
            this.groupBoxSingleStation.Name = "groupBoxSingleStation";
            this.groupBoxSingleStation.Size = new System.Drawing.Size(268, 262);
            this.groupBoxSingleStation.TabIndex = 5;
            this.groupBoxSingleStation.TabStop = false;
            this.groupBoxSingleStation.Text = "Station wählen";
            // 
            // btnShowNearestStations
            // 
            this.btnShowNearestStations.Location = new System.Drawing.Point(7, 55);
            this.btnShowNearestStations.Name = "btnShowNearestStations";
            this.btnShowNearestStations.Size = new System.Drawing.Size(255, 23);
            this.btnShowNearestStations.TabIndex = 6;
            this.btnShowNearestStations.Text = "Stationen in der meiner Nähe anzeigen";
            this.btnShowNearestStations.UseVisualStyleBackColor = true;
            this.btnShowNearestStations.Click += new System.EventHandler(this.btnShowNearestStations_Click);
            // 
            // btnShowStationOnMap
            // 
            this.btnShowStationOnMap.Location = new System.Drawing.Point(7, 230);
            this.btnShowStationOnMap.Name = "btnShowStationOnMap";
            this.btnShowStationOnMap.Size = new System.Drawing.Size(255, 26);
            this.btnShowStationOnMap.TabIndex = 5;
            this.btnShowStationOnMap.Text = "Station auf der Karte ansehen";
            this.btnShowStationOnMap.UseVisualStyleBackColor = true;
            this.btnShowStationOnMap.Click += new System.EventHandler(this.btnShowStationOnMap_Click);
            // 
            // listBoxSingleStation
            // 
            this.listBoxSingleStation.FormattingEnabled = true;
            this.listBoxSingleStation.Location = new System.Drawing.Point(7, 84);
            this.listBoxSingleStation.Name = "listBoxSingleStation";
            this.listBoxSingleStation.Size = new System.Drawing.Size(255, 108);
            this.listBoxSingleStation.TabIndex = 4;
            this.listBoxSingleStation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSingleStation_MouseClick);
            this.listBoxSingleStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxSingleStation_KeyDown);
            // 
            // btnSearchSingleStation
            // 
            this.btnSearchSingleStation.Location = new System.Drawing.Point(7, 198);
            this.btnSearchSingleStation.Name = "btnSearchSingleStation";
            this.btnSearchSingleStation.Size = new System.Drawing.Size(255, 26);
            this.btnSearchSingleStation.TabIndex = 3;
            this.btnSearchSingleStation.Text = "Abfahrten anzeigen";
            this.btnSearchSingleStation.UseVisualStyleBackColor = true;
            this.btnSearchSingleStation.Click += new System.EventHandler(this.btnSearchSingleStation_Click);
            // 
            // textBoxSingleStation
            // 
            this.textBoxSingleStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSingleStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSingleStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSingleStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSingleStation.Location = new System.Drawing.Point(7, 25);
            this.textBoxSingleStation.Name = "textBoxSingleStation";
            this.textBoxSingleStation.Size = new System.Drawing.Size(255, 26);
            this.textBoxSingleStation.TabIndex = 2;
            this.textBoxSingleStation.TextChanged += new System.EventHandler(this.textBoxSingleStation_TextChanged);
            this.textBoxSingleStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSingleStation_KeyDown);
            // 
            // groupBoxDepartures
            // 
            this.groupBoxDepartures.Controls.Add(this.dataGridViewDepartures);
            this.groupBoxDepartures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDepartures.Location = new System.Drawing.Point(15, 292);
            this.groupBoxDepartures.Name = "groupBoxDepartures";
            this.groupBoxDepartures.Size = new System.Drawing.Size(881, 183);
            this.groupBoxDepartures.TabIndex = 4;
            this.groupBoxDepartures.TabStop = false;
            this.groupBoxDepartures.Text = "Abfahrten";
            // 
            // dataGridViewDepartures
            // 
            this.dataGridViewDepartures.AllowUserToAddRows = false;
            this.dataGridViewDepartures.AllowUserToDeleteRows = false;
            this.dataGridViewDepartures.AllowUserToOrderColumns = true;
            this.dataGridViewDepartures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDeparture,
            this.columnName,
            this.columnDestination});
            this.dataGridViewDepartures.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDepartures.Name = "dataGridViewDepartures";
            this.dataGridViewDepartures.ReadOnly = true;
            this.dataGridViewDepartures.Size = new System.Drawing.Size(869, 158);
            this.dataGridViewDepartures.TabIndex = 0;
            // 
            // columnDeparture
            // 
            this.columnDeparture.HeaderText = "Abfahrt";
            this.columnDeparture.Name = "columnDeparture";
            this.columnDeparture.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnDestination
            // 
            this.columnDestination.HeaderText = "Ziel";
            this.columnDestination.Name = "columnDestination";
            this.columnDestination.ReadOnly = true;
            // 
            // tabPageTravel
            // 
            this.tabPageTravel.Controls.Add(this.btnShowDepartures);
            this.tabPageTravel.Controls.Add(this.groupBoxArrivals);
            this.tabPageTravel.Controls.Add(this.groupBoxDeparture);
            this.tabPageTravel.Controls.Add(this.groupBoxConnections);
            this.tabPageTravel.Location = new System.Drawing.Point(4, 22);
            this.tabPageTravel.Name = "tabPageTravel";
            this.tabPageTravel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTravel.Size = new System.Drawing.Size(902, 481);
            this.tabPageTravel.TabIndex = 1;
            this.tabPageTravel.Text = "Reise planen";
            this.tabPageTravel.UseVisualStyleBackColor = true;
            // 
            // btnShowDepartures
            // 
            this.btnShowDepartures.Location = new System.Drawing.Point(115, 221);
            this.btnShowDepartures.Name = "btnShowDepartures";
            this.btnShowDepartures.Size = new System.Drawing.Size(678, 29);
            this.btnShowDepartures.TabIndex = 9;
            this.btnShowDepartures.Text = "Abfahrten anzeigen";
            this.btnShowDepartures.UseVisualStyleBackColor = true;
            this.btnShowDepartures.Click += new System.EventHandler(this.btnShowDepartures_Click);
            // 
            // groupBoxArrivals
            // 
            this.groupBoxArrivals.Controls.Add(this.listBoxTripStation2);
            this.groupBoxArrivals.Controls.Add(this.textBoxStation2);
            this.groupBoxArrivals.Location = new System.Drawing.Point(537, 12);
            this.groupBoxArrivals.Name = "groupBoxArrivals";
            this.groupBoxArrivals.Size = new System.Drawing.Size(256, 197);
            this.groupBoxArrivals.TabIndex = 8;
            this.groupBoxArrivals.TabStop = false;
            this.groupBoxArrivals.Text = "Ankunft wählen";
            // 
            // listBoxTripStation2
            // 
            this.listBoxTripStation2.FormattingEnabled = true;
            this.listBoxTripStation2.Location = new System.Drawing.Point(10, 51);
            this.listBoxTripStation2.Name = "listBoxTripStation2";
            this.listBoxTripStation2.Size = new System.Drawing.Size(238, 134);
            this.listBoxTripStation2.TabIndex = 4;
            this.listBoxTripStation2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTripStation2_MouseClick);
            this.listBoxTripStation2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTripStation2_KeyDown);
            // 
            // textBoxStation2
            // 
            this.textBoxStation2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxStation2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxStation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStation2.Location = new System.Drawing.Point(10, 19);
            this.textBoxStation2.Name = "textBoxStation2";
            this.textBoxStation2.Size = new System.Drawing.Size(238, 26);
            this.textBoxStation2.TabIndex = 2;
            this.textBoxStation2.TextChanged += new System.EventHandler(this.textBoxStation2_TextChanged);
            this.textBoxStation2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStation2_KeyDown);
            // 
            // groupBoxDeparture
            // 
            this.groupBoxDeparture.Controls.Add(this.dateTimeTripStart);
            this.groupBoxDeparture.Controls.Add(this.listBoxTripStation1);
            this.groupBoxDeparture.Controls.Add(this.textBoxStation1);
            this.groupBoxDeparture.Location = new System.Drawing.Point(115, 12);
            this.groupBoxDeparture.Name = "groupBoxDeparture";
            this.groupBoxDeparture.Size = new System.Drawing.Size(248, 203);
            this.groupBoxDeparture.TabIndex = 7;
            this.groupBoxDeparture.TabStop = false;
            this.groupBoxDeparture.Text = "Abfahrt wählen";
            // 
            // dateTimeTripStart
            // 
            this.dateTimeTripStart.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimeTripStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTripStart.Location = new System.Drawing.Point(6, 177);
            this.dateTimeTripStart.Name = "dateTimeTripStart";
            this.dateTimeTripStart.Size = new System.Drawing.Size(236, 20);
            this.dateTimeTripStart.TabIndex = 10;
            this.dateTimeTripStart.Value = DateTime.Now;
            // 
            // listBoxTripStation1
            // 
            this.listBoxTripStation1.FormattingEnabled = true;
            this.listBoxTripStation1.Location = new System.Drawing.Point(6, 51);
            this.listBoxTripStation1.Name = "listBoxTripStation1";
            this.listBoxTripStation1.Size = new System.Drawing.Size(236, 121);
            this.listBoxTripStation1.TabIndex = 3;
            this.listBoxTripStation1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTripStation1_MouseClick);
            this.listBoxTripStation1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTripStation1_KeyDown);
            // 
            // textBoxStation1
            // 
            this.textBoxStation1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxStation1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxStation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStation1.Location = new System.Drawing.Point(6, 19);
            this.textBoxStation1.Name = "textBoxStation1";
            this.textBoxStation1.Size = new System.Drawing.Size(236, 26);
            this.textBoxStation1.TabIndex = 2;
            this.textBoxStation1.TextChanged += new System.EventHandler(this.textBoxStation1_TextChanged);
            this.textBoxStation1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStation1_KeyDown);
            // 
            // groupBoxConnections
            // 
            this.groupBoxConnections.Controls.Add(this.dataGridViewConnections);
            this.groupBoxConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConnections.Location = new System.Drawing.Point(15, 256);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(881, 219);
            this.groupBoxConnections.TabIndex = 6;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Verbindungen";
            // 
            // dataGridViewConnections
            // 
            this.dataGridViewConnections.AllowUserToAddRows = false;
            this.dataGridViewConnections.AllowUserToDeleteRows = false;
            this.dataGridViewConnections.AllowUserToOrderColumns = true;
            this.dataGridViewConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConnections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTripDeparture,
            this.columnTripEndTime,
            this.columnTripPlatform,
            this.columnTripStartStation,
            this.columnTripEndStation,
            this.columnTripTime});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConnections.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewConnections.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewConnections.Name = "dataGridViewConnections";
            this.dataGridViewConnections.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConnections.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewConnections.Size = new System.Drawing.Size(869, 194);
            this.dataGridViewConnections.TabIndex = 0;
            this.dataGridViewConnections.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewConnections_MouseClick);
            // 
            // columnTripDeparture
            // 
            this.columnTripDeparture.HeaderText = "Abfahrt";
            this.columnTripDeparture.Name = "columnTripDeparture";
            this.columnTripDeparture.ReadOnly = true;
            // 
            // columnTripEndTime
            // 
            this.columnTripEndTime.HeaderText = "Ankunft";
            this.columnTripEndTime.Name = "columnTripEndTime";
            this.columnTripEndTime.ReadOnly = true;
            // 
            // columnTripPlatform
            // 
            this.columnTripPlatform.HeaderText = "Gleis";
            this.columnTripPlatform.Name = "columnTripPlatform";
            this.columnTripPlatform.ReadOnly = true;
            // 
            // columnTripStartStation
            // 
            this.columnTripStartStation.HeaderText = "Start";
            this.columnTripStartStation.Name = "columnTripStartStation";
            this.columnTripStartStation.ReadOnly = true;
            // 
            // columnTripEndStation
            // 
            this.columnTripEndStation.HeaderText = "Ziel";
            this.columnTripEndStation.Name = "columnTripEndStation";
            this.columnTripEndStation.ReadOnly = true;
            // 
            // columnTripTime
            // 
            this.columnTripTime.HeaderText = "Fahrtzeit";
            this.columnTripTime.Name = "columnTripTime";
            this.columnTripTime.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anwendungToolStripMenuItem,
            this.designToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // anwendungToolStripMenuItem
            // 
            this.anwendungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
            this.anwendungToolStripMenuItem.Name = "anwendungToolStripMenuItem";
            this.anwendungToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.anwendungToolStripMenuItem.Text = "Anwendung";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Checked = true;
            this.lightModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.lightModeToolStripMenuItem.Text = "Standard";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.darkModeToolStripMenuItem.Text = "Dunkel";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // SwissInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.Controls.Add(this.tabControlSwissInterface);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SwissInterface";
            this.Text = "SwissInterface";
            this.Load += new System.EventHandler(this.SwissInterface_Load);
            this.tabControlSwissInterface.ResumeLayout(false);
            this.tabPageSingleStation.ResumeLayout(false);
            this.groupBoxSingleStation.ResumeLayout(false);
            this.groupBoxSingleStation.PerformLayout();
            this.groupBoxDepartures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartures)).EndInit();
            this.tabPageTravel.ResumeLayout(false);
            this.groupBoxArrivals.ResumeLayout(false);
            this.groupBoxArrivals.PerformLayout();
            this.groupBoxDeparture.ResumeLayout(false);
            this.groupBoxDeparture.PerformLayout();
            this.groupBoxConnections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSwissInterface;
        private System.Windows.Forms.TabPage tabPageSingleStation;
        private System.Windows.Forms.TabPage tabPageTravel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anwendungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSingleStation;
        private System.Windows.Forms.DataGridView dataGridViewDepartures;
        private System.Windows.Forms.GroupBox groupBoxDepartures;
        private System.Windows.Forms.Button btnSearchSingleStation;
        private System.Windows.Forms.GroupBox groupBoxSingleStation;
        private System.Windows.Forms.Button btnShowDepartures;
        private System.Windows.Forms.GroupBox groupBoxArrivals;
        private System.Windows.Forms.TextBox textBoxStation2;
        private System.Windows.Forms.GroupBox groupBoxDeparture;
        private System.Windows.Forms.TextBox textBoxStation1;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.DataGridView dataGridViewConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTripDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTripEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTripPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTripStartStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTripEndStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTripTime;
        private System.Windows.Forms.ListBox listBoxSingleStation;
        private System.Windows.Forms.ListBox listBoxTripStation2;
        private System.Windows.Forms.ListBox listBoxTripStation1;
        private System.Windows.Forms.DateTimePicker dateTimeTripStart;
        private System.Windows.Forms.Button btnShowStationOnMap;
        private System.Windows.Forms.Button btnShowNearestStations;
    }
}