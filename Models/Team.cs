﻿using System.Collections.Generic;

namespace MotoGP.Models
{
    public class Team
    {
        public int TeamID { get;  set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public ICollection<Rider> Riders { get; set; }
        
    }
}