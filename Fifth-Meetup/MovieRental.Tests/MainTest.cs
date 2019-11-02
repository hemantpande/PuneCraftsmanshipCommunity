using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.ClassLibrary;

namespace MovieRental.Tests
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void Customer_GenerateTextStatement() 
        {
            CustInfo c = new CustInfo("John Doe");

            c.addRental(new RentalDetails(new MovieData("Harry Potter", 0), 4));
            c.addRental(new RentalDetails(new MovieData("John Wick", 2), 10));
            c.addRental(new RentalDetails(new MovieData("The Boult",1), 20));

            String actual = c.statement();

            Assert.AreEqual("Rental Record for John Doe\n" +
                    "\tHarry Potter\t5\n" +
                    "\tJohn Wick\t12\n" +
                    "\tThe Boult\t60\n" +
                    "Amount owed is 77\n" +
                    "You earned 4 frequent renter points", actual);

        }
    }
}
