namespace EDA_Customer_API.DTO
{
    public class CustomerDto
    {
        public string Name { get; set; } = string.Empty;
        public Guid ProductId { get; set; }
        public int ItemInCart { get; set; }
    }
}
