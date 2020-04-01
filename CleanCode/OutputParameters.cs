using System;
using System.Collections.Generic;

namespace CleanCode
{
    public class OutputParameters
    {
        public class GetCustomersResult
        {
            public IEnumerable<Customer> Items1 { get; set; }
            public int Items2 { get; set; }
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
            return new GetCustomersResult() { Item1 = new List<Customer>(), Item2 = totalCount}
        }
    }
}
