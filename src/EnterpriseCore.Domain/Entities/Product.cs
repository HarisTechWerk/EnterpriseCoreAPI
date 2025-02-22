using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseCore.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime? DeletedAt { get; set; } // ✅ Soft Delete column
    }
}
