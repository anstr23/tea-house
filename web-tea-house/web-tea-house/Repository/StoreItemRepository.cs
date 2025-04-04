using web_tea_house.Models;

namespace web_tea_house.Repository
{
    public class StoreItemRepository
    {
        public static List<StoreItemModel> GetStoreItems() => new List<StoreItemModel>
    {
         new StoreItemModel
        {
            Id = 1,
            ImageSrc = "img/store-product-1.jpg",
            TitleTea = "Зелений чай Тулсі",
            DescriptionTea = "Цей зелений чай з Тулсі має ніжний аромат і корисні властивості для здоров'я. Допомагає зняти стрес і підвищити енергію.",
            Price = 19.00m,
            Rating = 5
        },
        new StoreItemModel
        {
            Id = 2,
            ImageSrc = "img/store-product-2.jpg",
            TitleTea = "Чорний чай Ассам",
            DescriptionTea = "Насичений і міцний чорний чай з регіону Ассам, ідеальний для ранкового підбадьорення.",
            Price = 15.50m,
            Rating = 4
        },
        new StoreItemModel
        {
            Id = 3,
            ImageSrc = "img/store-product-3.jpg",
            TitleTea = "Інстантний чай премікс",
            DescriptionTea = "Швидкий і зручний інстантний чай премікс, який можна приготувати за кілька хвилин. Ідеально підходить для людей на ходу.",
            Price = 14.00m,
            Rating = 4
        }
    };
    }
}
