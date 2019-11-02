using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.ClassLibrary;

namespace MovieRental.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Customer_GenerateTextStatement() 
        {
            Customer customer = new Customer("John Doe");

            customer.addRental(new Rental(new Movie("Harry Potter", Movie.REGULAR), 4));
            customer.addRental(new Rental(new Movie("John Wick", Movie.CHILDRENS), 10));
            customer.addRental(new Rental(new Movie("The Boult", Movie.NEW_RELEASE), 20));

            String statement = customer.statement();

            Assert.AreEqual("Rental Record for John Doe\n" +
                    "\tHarry Potter\t5\n" +
                    "\tJohn Wick\t12\n" +
                    "\tThe Boult\t60\n" +
                    "Amount owed is 77\n" +
                    "You earned 4 frequent renter points", statement);

        }
    }
}
