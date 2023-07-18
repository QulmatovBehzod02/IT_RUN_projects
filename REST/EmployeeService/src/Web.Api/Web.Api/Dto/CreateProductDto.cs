namespace Web.Api.Dto
{
    public record CreateProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Ram { get; set; }
        public string CPU { get; set; }
        public int HardDrive { get; set; }
    }
}
