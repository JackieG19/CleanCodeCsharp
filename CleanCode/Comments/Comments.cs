using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;

namespace CleanCode.Comments
{
    public class Comments
    {
        private int _payFequency;
        private CustomesrDbContext _dbContext;
        
        public Comments()
        {
            _dbContext = CustomesrDbContext();
        }
        
        // return list of customers in a country
        public List<Customer> GetCustomer(int countryCode)
        {   
            throw new NotImplementedException();
        }
        
        public void SumbitOrder(Order order)
        {
            SaveOrder(order);
            NotifyCustomer(order);
        }
        
        private void SaveOrder(Order order)
        {
            // save the order in the database
            _dbContext.Order.Add(order);
            _dbContext.SaveChange();
            
            NotifyCustomer(order);
        }
        
        private static void NotifyCustomer(Order order)
        {
            var client = new SmtpClient();
            var mail = newMailMessage("noreply@site.com", order.Customer.Email, "Your order placed successfully", ".")
            client.Send(mail);
        }
    }
    
    #region Supporting Clases
    
    public class Order
    {
        public Customer Customer { get; set; }
    }
}
