using System;

namespace MovieRental.ClassLibrary
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private String title;
        private int priceCode;

        public Movie(String title, int priceCode)
        {
            this.title = title;
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

        public String getTitle()
        {
            return title;
        }
    }
}