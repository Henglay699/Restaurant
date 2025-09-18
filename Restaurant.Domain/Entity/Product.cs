
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Domain.Entity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        public required string Name { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        [MaxLength(60)]
        public string? Description { get; set; }

        [Precision(10,2)]
        public decimal UnitPrice { get; set; }

        [MaxLength(100)]
        public string? Image { get; set; }

        public DateTime TimeCreated { get; set; }

        
    }
}