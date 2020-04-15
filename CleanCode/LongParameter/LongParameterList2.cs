using system;
using System.Collections.Generic;

namespace CleanCode
{
    public class DataRange
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;
            
        public DataRange(DateTime dateFrom, DateTime dateTo)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;
        }
            
        public DateTime DateFrom
        {
            get { return _dateFrom; }
        }
            
        public DateTime DateTo
        {
            get { return dateTo; }
        }
    }
    
    public class LongParameterLists
    {
        public IEnumerable<Reservation> GetReservations(DataRange dataRange User user, 
            int locationId, LocationType locationType, int? customerId = null)
        {
            if(dataRange.DateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dataRange.DateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
        public IEnumerable<Reservation> GetUpcomingReservations(DataRange dataRange, User user, int locationId, LocationType locationType)
        {
            if(dataRange.DateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dataRange.DateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
        private static Tuple<DateTime, DateTime> GetReservationDateRange(DataRange dataRange, ReservationDefinition sd)
        {
            if(dataRange.DateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dataRange.DateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
        public void CreateReservation<DateTime, DateTime> GetReservationDateRange(DataRange dataRange, int locationId)
        {
            if(dataRange.DateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(dataRange.DateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
    }
    
    internal class ReservationDefinition
    {
        // empty class 
    }
}
