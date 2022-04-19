namespace API.Entities
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }
}

