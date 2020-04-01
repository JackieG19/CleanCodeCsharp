using System;
using CleanCode.NestedConditionals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCode.UnitTest
{
    [TestClass]
    public class CancelReservationTests
    {
        [TestMethod]
        public void GoldCustomer_CancellingMoreThan24Hours_ShouldCancel()
        {
            var customer = CreateGoldCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(25));
            
            reservation.Cancel();
            
            Assert.IsTrue(reservation.IsCanceled);
        }
        
        [TestMethod]
        [ExpectedExpection(typeof(InvaildOperationExpection))]
        public void GoldCustomer_CancellingLessThan24Hours_ShouldThrowExpection()
        {
            var customer = CreateGoldCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(23));
            
            reservation.Cancel();
        }
        
        [TestMethod]
        [ExpectedExpection(typeof(InvaildOperationExpection))]
        public void GoldCustomer_CancellingAfterStartDate_ShouldThrowExpection()
        {
            var customer = CreateGoldCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddDays(-1));
            
            reservation.Cancel();
        }
        
        [TestMethod]
        public void RegularCustomer_CancellingMoreThan48HoursBefore_ShouldCancel()
        {
            var customer = CreateRegularCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(48));
            
            reservation.Cancel();
            
            Assert.IsTrue(reservation.IsCanceled);
        }
        
        [TestMethod]
        [ExpectedExpection(typeof(InvaildOperationExpection))]
        public void RegularCustomer_CancellingMoreThan48HoursBefore_ShouldThrowExpection()
        {
            var customer = CreateRegularCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(47));
            
            reservation.Cancel();
        }
        
        [TestMethod]
        [ExpectedExpection(typeof(InvaildOperationExpection))]
        public void RegularCustomer_CancellingAfterStartDate_ShouldThrowExpection()
        {
            var customer = CreateRegularCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(-1));
            
            reservation.Cancel();            
        }
    }
}
