using System;
using TDD_S1.Domian.Flights.Exceptions;
using TDD_S1.Domian.Utility;

namespace TDD_S1.Domian.Flights
{
    public  class Flight
    {
        public DateTime ArriveDate { get; private set; }
        public DateTime DepartDate { get; private set; }


        public Flight(DateTime departDate, DateTime arriveDate  )
        {
            if(arriveDate.IsPast()) throw new InvalidArriveDateException();
            if(departDate.IsPast()) throw new InvalidDepartDateException();
            if(arriveDate.IsBefore(departDate)) throw new InvalidArriveDateDepartDateCombinationException();

            ArriveDate = arriveDate;
            DepartDate = departDate;
        }
    }
}
