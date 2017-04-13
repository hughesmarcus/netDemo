using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Item
    {
       
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
    }
}