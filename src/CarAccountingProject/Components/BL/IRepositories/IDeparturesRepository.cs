using System;
using System.Collections.Generic;

namespace BL
{
    public interface IDeparturesRepository
    {
        List<Departure> GetDepartures(int offset = 0, int limit = -1);
        List<Departure> GetDeparturesByDate(DateTime date);
        List<Departure> GetDeparturesByUserId(int uId);
        Departure GetDepartureById(int id);
        void AddDeparture(Departure dep);
        void DeleteDeparture(int id);
    }
}