using web_tea_house.Models;

namespace web_tea_house.Repository
{
    public class IndexPageRepository
    {
        public static List<CardItemModel> GetTeaCards() => new List<CardItemModel>
    {
        new CardItemModel
        {
            Id = 1,
            ImageSrc = "./img/product-1.jpg",
            CardTitle = "Зелений чай",
            CardDescription = "Ніжний аромат та свіжий смак. Ідеальний для ранкового пробудження.",
            ShortDescription = "Освіжаючий зелений чай."
        },
        new CardItemModel
        {
            Id = 2,
            ImageSrc = "./img/product-2.jpg",
            CardTitle = "Чорний чай",
            CardDescription = "Класичний міцний чай з насиченим смаком.",
            ShortDescription = "Енергійний чорний чай."
        },
        new CardItemModel
        {
            Id = 3,
            ImageSrc = "./img/product-3.jpg",
            CardTitle = "Улун",
            CardDescription = "Гармонія між зеленим та чорним чаєм. Насичений, м'який післясмак.",
            ShortDescription = "Ароматний улун."
        }
    };
    }
}
