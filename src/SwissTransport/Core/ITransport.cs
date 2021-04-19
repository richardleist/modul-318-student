namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;

    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Stations GetStationsByCoords(double x, double y);

        Connections GetConnections(string fromStation, string toStation, DateTime dateTime);
    }
}