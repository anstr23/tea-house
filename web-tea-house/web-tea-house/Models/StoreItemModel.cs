namespace web_tea_house.Models
{
    public class StoreItemModel
    {
        public int Id { get; set; }
        public string ImageSrc { get; set; }
        public string TitleTea { get; set; }
        public string DescriptionTea { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
