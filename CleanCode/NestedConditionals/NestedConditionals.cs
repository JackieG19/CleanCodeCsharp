using System;

namespace CleanCode
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }
    
    public class Reservation
    {
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }
        
        public DateTime From { get; set; }
        public Customer customer { get; set; }
        public bool IsCanceled { get; set; }
        
        public void Cancel()
        {
            if(IsAlreadyStarted() || IsCancellationPeriodOver())
                throw new InvaildOperationExecption("It's too late to cancel");                   
            IsCanceled = true;
        }
        
        private bool IsCancellationPeriodOver()
        {
            return (IsGoldCustomer() && LessThan(24)) ||
                    !IsGoldCustomer() && LessThan(48);
        }
        
        private bool LessThan(int maxHouse)
        {
            return (From - DateTime.Now).TotalHours < maxHouse;
        }
    }
}
