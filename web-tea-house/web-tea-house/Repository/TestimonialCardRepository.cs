using web_tea_house.Models;

namespace web_tea_house.Repository
{
    public class TestimonialCardRepository
    {
        public static List<TestimonialCardModel> GetTestimonialCards() => new List<TestimonialCardModel>
    {
         new TestimonialCardModel
        {
            Id = 1,
            ImageSrc = "./img/testimonial-1.jpg",
            Title = "Олена, любителька трав'яних чаїв",
            Text = "Я п'ю чай кожен день, і це справжня магія для душі. Зелений чай із жасмином – мій улюблений! Я відчуваю, як цей чай розслабляє і налаштовує на спокій.",
            LastUpdated = "Оновлено 5 хвилин тому."
        },
        new TestimonialCardModel
        {
            Id = 2,
            ImageSrc = "./img/testimonial-2.jpg",
            Title = "Артем, чайний експерт ",
            Text = "Трав'яні чаї – це моє все! М'ятний і ромашковий настій – ідеальні для вечірнього релаксу. Я завжди відчуваю, як ці чаї дарують гармонію і спокій після важкого дня.",
            LastUpdated = "Оновлено 10 хвилин тому"
        },
        new TestimonialCardModel
        {
            Id = 3,
            ImageSrc = "./img/testimonial-3.jpg",
            Title = "Іванка, чайний блогер",
            Text = "Чай – це більше, ніж напій, це справжня культура! Особливо люблю чорний чай з Бергамотом. У ньому є особливий смак і аромат, який допомагає зосередитися і налаштуватися на робочий лад.",
            LastUpdated = "Оновлено 15 хвилин тому"
        }
    };
    }
}
