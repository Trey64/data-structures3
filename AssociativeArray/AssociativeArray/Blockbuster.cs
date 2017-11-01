using System;
using System.Collections.Generic;
using System.Text;

namespace AssociativeArray
{
    class Blockbuster
    {
        public string Movie { get; set; }
        public string Person { get; set; }

        public Blockbuster(string movie, string person)
        {
            Movie = movie;
            Person = person;
        }

        public string RentMovie()
        {
            return Movie;
        }

        public string GetPerson()
        {
            return Person;
        }

        public string MoviesOnLoan()
        {
            return RentMovie() + "" + GetPerson();
        }
    }
}
