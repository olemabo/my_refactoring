﻿using System;


namespace RefactoringSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test space.");
            testSpace();
        }
        private Movie _movie;

        public Program(string title, int movieType)
        {
            _movie = new Movie(title, movieType);

        }

        public void SetMovie(string title, int movieType)
        {
            _movie = new Movie(title, movieType);
        }

        public Movie GetMovie()
        {
            return _movie;
        }

        public static void testSpace()
        {
            string costumer = "Ole Martin";
            var customer = new Customer(costumer);

            customer.AddRental(new Rental(new Movie("Avengers: Endgame", Movie.REGULAR), 1));
            customer.AddRental(new Rental(new Movie("The Lion King", Movie.CHILDRENS), 2));

            var statement = customer.Statement();
            Console.WriteLine(statement);

            var htmlStatement = customer.HtmlStatement();
            Console.WriteLine(htmlStatement);

        }
    }
}
