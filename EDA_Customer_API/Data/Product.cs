using System.ComponentModel.DataAnnotations;

namespace EDA_Customer_API.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
