using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.API.Models
{
    public class BoredActivity
    {

        public Guid Id { get; set; }

        public string activity { get; set; }

        public string interesting { get; set; }

        public int participants { get; set; }   

        public double price { get; set; }

        public string link { get; set; }

        public string key { get; set; }

        public int accessibility { get; set; }
    }
}
