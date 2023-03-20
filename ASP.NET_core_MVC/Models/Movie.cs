using System;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_core_MVC.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public decimal Revene { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleseDate { get; set; }
    }
}

