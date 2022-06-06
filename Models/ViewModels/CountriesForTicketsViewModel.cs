using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MotoGP.Models.ViewModels
{
    public class CountriesForTicketsViewModel
    {
        public Ticket Ticket { get; set; }
        public SelectList Countries { get; set; }

        [Display(Name = "Race")]
        public List<Race> Races { get; set; }
        [Display(Name = "Country")]
        public int CountryID { get; set; }

    }
}
