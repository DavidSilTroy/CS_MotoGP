using System.Collections.Generic;

namespace MotoGP.Models.ViewModels
{
    public class ListRacesViewModel
    {
        public string MonthName { get; set; }
        public List<Race> Races { get; set; }
    }
}
