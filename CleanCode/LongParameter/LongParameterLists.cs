using system;
using System.Collections.Generic;

namespace CleanCode
{
    public class LongParameterLists
    {
        public IEnumerable<Reservation> GetReservations(
            DateTime dateFrom, DateTime dateTo, User user, 
            int locationId, LocationType locationType, 
            int? customerId = null)
        {
            if(dateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
         public IEnumerable<Reservation> GetUpcomingReservations(
            DateTime dateFrom, DateTime dateTo, User user, 
            int locationId, LocationType locationType)
        {
            if(dateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateTime dateFrom, DateTime dateTo, ReservationDefinition)
        {
            if(dateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
        public void CreateReservation<DateTime, DateTime> GetReservationDateRange(DateTime dateFrom, DateTime dateTo, int locationId)
        {
            if(dateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
    }
    
    internal class ReservationDefinition
    {
        // empty class
    }
}
