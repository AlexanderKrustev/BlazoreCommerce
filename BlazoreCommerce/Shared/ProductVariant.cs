namespace BlazoreCommerce.Shared
{
    public class ProductVariant
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }
    }
}
