namespace SwissTransport.Core
{
    using System;
    using System.Net;

    using Newtonsoft.Json;

    using SwissTransport.Models;

    public class Transport : ITransport, IDisposable
    {
        public const string WebApiHost = "http://transport.opendata.ch/v1/";

        protected readonly IHttpClient HttpClient =
            new HttpClient(CredentialCache.DefaultNetworkCredentials, WebRequest.DefaultWebProxy);

        public Stations GetStations(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var uri = new Uri($"{WebApiHost}locations?query={query}");
            var returnString = HttpClient.GetString(uri);
            if (returnString == null)
                return null;
            return JsonConvert.DeserializeObject<Stations>(returnString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            if (string.IsNullOrEmpty(station))
            {
                throw new ArgumentNullException(nameof(station));
            }

            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }
            var uri = new Uri($"{WebApiHost}stationboard?station={station}&id={id}");
            var returnString = HttpClient.GetString(uri);
            if (returnString == null)
                return null;
            return JsonConvert.DeserializeObject<StationBoardRoot>(returnString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        public Stations GetStationsByCoords(double x, double y)
        {
            if (x == 0)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y == 0)
            {
                throw new ArgumentNullException(nameof(y));
            }
            var uri = new Uri($"{WebApiHost}locations?x={x.ToString("0.0000000", System.Globalization.CultureInfo.InvariantCulture)}&y={y.ToString("0.0000000", System.Globalization.CultureInfo.InvariantCulture)}");
            var returnString = HttpClient.GetString(uri);
            if (returnString == null)
                return null;
            return JsonConvert.DeserializeObject<Stations>(returnString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        public Connections GetConnections(string fromStation, string toStation, DateTime dateTime)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            if (dateTime == null)
            {
                throw new ArgumentNullException(nameof(dateTime));
            }
            string date = System.Uri.EscapeDataString(dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString());
            string time = System.Uri.EscapeDataString(dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString());
            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}&date={date}&time={time}&isArrivalTime=0");
            var returnString = HttpClient.GetString(uri);
            if (returnString == null)
                return null;
            return JsonConvert.DeserializeObject<Connections>(returnString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        public void Dispose()
        {
            HttpClient?.Dispose();
        }
    }
}