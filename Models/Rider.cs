﻿namespace MotoGP.Models
{
    public class Rider
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int TeamID { get; set; }
        public int CountryID { get; set; }
        public string Bike { get;  set; }
        public int Number { get; set; }

        public Team Teams { get; set; }
        public Country Countries { get; set; }
    }
}
