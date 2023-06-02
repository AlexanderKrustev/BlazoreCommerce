using System.Text.Json.Serialization;

namespace BlazoreCommerce.Shared
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product Product { get; set; }

        public int ProductId { get; set; }

        public ProductType ProductType { get; set; }

        public int ProductTypeId { get; set; }

    }
}
