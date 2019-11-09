namespace MovieRental.ClassLibrary
{
    using System;
    using System.Collections.Generic;

    public class CustInfo
    {
        private String cust_name;
        private List<RentalDetails> rentals = new List<RentalDetails>();

        public CustInfo(String name)
        {
            this.cust_name = name;
        }

        public void addRental(RentalDetails arg)
        {
            rentals.Add(arg);
        }

        public String getCustName()
        {
            return cust_name;
        }

        public String statement()
        {
            double temp = 0;
            int points = 0;
            String result = "Rental Record for " + getCustName() + "\n";
            foreach (RentalDetails rd in rentals)
            {
                double amt = 0;

                switch (rd.getMovie().getPriceCode())
                {
                    case 0: //常規電影 Chángguī diànyǐng
                        amt += 2;
                        if (rd.getDaysRented() > 2)
                            amt += (rd.getDaysRented() - 2) * 1.5;
                        break;

                    case 1:  // Film récemment sorti
                        amt += rd.getDaysRented() * 3;
                        break;

                    case 2: //छोटे बच्चो की मूवीज 
                        amt += 1.5;
                        if (rd.getDaysRented() > 3)
                            amt += (rd.getDaysRented() - 3) * 1.5;
                        break;
                }

                // add frequent renter points
                points++;
                
                // add bonus for a two day new release rental
                if ((rd.getMovie().getPriceCode() == 1)
                        &&
                        rd.getDaysRented() > 1) points++;

                //show figures for this rental
                result += "\t" + rd.getMovie().getMovieTitle() + "\t" +
                        amt + "\n";
                temp += amt;
            }

            //add footer lines result
            result += "Amount owed is " + temp + "\n";
            result += "You earned " + points
                    + " frequent renter points";
            return result;
        }
    }

    public class RentalDetails
    {
        private int daysRented;
        private MovieData movie;

        public RentalDetails(MovieData movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public int getDaysRented()
        {
            return daysRented;
        }

        public MovieData getMovie()
        {
            return movie;
        }
    }

    public class MovieData
    {
        private String movieTitle;
        private int priceCode;

        public MovieData(String title, int priceCode)
        {
            this.movieTitle = title;
            this.priceCode = priceCode;
        }

        public int getPriceCode()
        {
            return priceCode;
        }

        public void setPriceCode(int arg)
        {
            priceCode = arg;
        }

        public String getMovieTitle()
        {
            return movieTitle;
        }
    }
}