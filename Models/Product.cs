using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MopMarvels.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime MFGDate { get; set; }
        public string? SerialNumber { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }

        public string? Category { get; set; }
    }
}
