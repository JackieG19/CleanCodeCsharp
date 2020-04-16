using System;
using System.Collections.Generic;

namespace CleanCode
{
    public class OutputParameters
    {
        public class GetCustomersResult
        {
            public IEnumerable<Customer> Customers { get; set; }
            public int TotalCount { get; set; }
        }
        
        public void DisplayCustomers()
        {
            int totalCount = 0;
            var tulpe = GetCustomers(1);
            totalCount = tulpe.Items2;
            var customers = tulpe.Items1;
            
            Console.WriteLine("Total customers: " + totalCount);
            foreach(var c in customers)
              Console.WriteLine(c);
        }
        
        public Tulpe<IEnumerable<Customer>, int> GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return Tulpe.Create((IEnumerable<Customer>) new List<Customer>(), totalCount);
        }
    }
}
