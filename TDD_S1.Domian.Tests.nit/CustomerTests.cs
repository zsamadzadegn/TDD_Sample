using System;
using TDD_S1.Domian.Flights;
using TDD_S1.Domian.Flights.Exceptions;
using Xunit;

namespace TDD_S1.Domian.Tests.nit
{
    public class CustomerTests
    {
        [Fact]
        public void When_Creating_Flight_Its_Depart_Date_Should_Not_Be_Past()
        {
            var pastDate = DateTime.Now.AddDays(-1);
            Assert.Throws<InvalidDepartDateException>(() =>
            {
                var flight = new Flight(pastDate, DateTime.Now.AddDays(3));
            });
        }


        [Fact]
        public void When_Creating_Flight_Its_Arrivate_Date_Should_Not_Be_Past()
        {
            var pastDate = DateTime.Now.AddDays(-1);
            Assert.Throws<InvalidArriveDateException>(() =>
            {
                var flight = new Flight(DateTime.Now.AddDays(3), pastDate);
            });
        }


        [Fact]
        public void When_Arrive_Date_Is_Before_Depart_Date_should_throw_Exception()
        {
            var departDate = DateTime.Now.AddDays(10);
            var arrivaDate = DateTime.Now.AddDays(9);


            Assert.Throws<InvalidArriveDateDepartDateCombinationException>(() =>
            {
                var flight = new Flight(departDate, arrivaDate);
            });
        }
    }
}
