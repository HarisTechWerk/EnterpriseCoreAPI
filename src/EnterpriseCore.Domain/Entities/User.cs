using System;

namespace EnterpriseCore.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new();

        public DateTime? DeletedAt { get; set; } // ✅ Soft Delete column
    }
}
