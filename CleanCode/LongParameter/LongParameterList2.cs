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
    
    public class ReservationQuery
    {
        private DataRange _dataRange;
        private User _user;
        private int _locationId;
        private LocationType _locationType;
        private int? _customerId;
        
        public ReservationQuery(DataRange dataRange User user, int locationId, LocationType locationType, int? customerId = null)
        {
            _dataRange = dataRange;
            _user = user;
            _locationId = locationId;
            _locationType = locationType;
            _customerId = customerId;
        }
        
        public DataRange DataRange
        {
            get { return _dataRange; }
        }
        
        public User User
        {
            get { return _user; }
        }
        
        public int LocationId
        {
            get { return _locationId; }
        }
        
        public LocationType LocationType
        {
            get { return _locationType; }
        }
        
        public int? CustomerId
        {
            get { return _customerId; }
        }
    }
    
    public class LongParameterLists
    {
        public IEnumerable<Reservation> GetReservations(ReservationQuery, query)
        {
            if(query.DataRange.DateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(query.DataRange.DateTo >= DateTime.Now)
              throw new ArgumentNullException("dateTo"); 
              
            throw new NotImplementedException();
        }
        
        public IEnumerable<Reservation> GetUpcomingReservations(ReservationQuery, query)
        {
            if(query.DataRange.DateFrom >= DateTime.Now)
              throw new ArgumentNullException("dateFrom");
            if(query.DataRange.DateTo >= DateTime.Now)
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
