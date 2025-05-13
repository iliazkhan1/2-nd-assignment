using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2_nd_assignment.Models
{
    public class Product
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Cannot be null
        public string Name { get; set; }

        [Precision(18, 2)] // Fixes decimal precision warning
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
