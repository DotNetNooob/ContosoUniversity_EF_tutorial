using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity_EF_tutorial.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
    }
}