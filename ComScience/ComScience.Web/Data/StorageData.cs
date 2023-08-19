using ComScience.Web.Models;

namespace ComScience.Web.Data
{
    public class StorageData
    {
        public BannerData BannerData { get; set; }

        public IEnumerable<Article> Articles { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public StorageData()
        {
            FillBannerData();
            FillArticles();
            FillProducts();
        }

        private void FillBannerData()
        {
            BannerData = new BannerData()
            {
                Title = "Лучшее приложение для химиков",
                ContentHTML = "<img src=\"/img/banner.png\" class=\"card-img\" alt=\"Фонд содействия инновациям\"><p>Какой-то текст</p>"
            };
        }

        private void FillArticles()
        {
            Articles = new List<Article>()
            {
                new Article()
                {
                    Id = 1,
                    Title = "Лучшее приложение для женщин",
                    ContentHTML = "",
                    ImgPath = "/img/banner.png",
                    DatePublication = DateTime.Now,
                    ImgAlt = "Фонд содействия инновациям",
                    Tag = "collapse1"
                },
                new Article()
                {
                    Id = 2,
                    Title = "Лучшее приложение для мужчин",
                    ContentHTML = "",
                    ImgPath = "/img/banner.png",
                    DatePublication = DateTime.Now,
                    ImgAlt = "Фонд содействия инновациям",
                    Tag = "collapse2"
                },
                new Article()
                {
                    Id = 3,
                    Title = "Лучшее приложение для детей",
                    ContentHTML = "",
                    ImgPath = "/img/banner.png",
                    DatePublication = DateTime.Now,
                    ImgAlt = "Фонд содействия инновациям",
                    Tag = "collapse3"
                },
                new Article()
                {
                    Id = 4,
                    Title = "Лучшее приложение для родителей",
                    ContentHTML = "",
                    ImgPath = "/img/banner.png",
                    DatePublication = DateTime.Now,
                    ImgAlt = "Фонд содействия инновациям",
                    Tag = "collapse4"
                },
                new Article()
                {
                    Id = 5,
                    Title = "И, вообще, заебал, купи его",
                    ContentHTML = "<p class=\"mt-4\">Не купишь, тогда пиши адрес, мы заставим купить</p>",
                    ImgPath = "/img/banner.png",
                    DatePublication = DateTime.Now,
                    ImgAlt = "Фонд содействия инновациям",
                    Tag = "collapse5"
                }
            };
        }

        private void FillProducts()
        {
            Products = new List<Product>()
            {
                new Product() 
                { 
                    Id = 1,
                    Name = "asdasdasd",
                    Description = "asdasdasd",
                    Modules = new List<Module>()
                    {
                        new Module
                        {
                            Id = 1,
                            Title = "Module 1",
                            ContentHtml = "<h1>1111111111111</h1>"
                        },
                        new Module
                        {
                            Id = 2,
                            Title = "Module 2",
                            ContentHtml = "<h1>2222222222222</h1>"
                        },
                        new Module
                        {
                            Id = 3,
                            Title = "Module 3",
                            ContentHtml = "<h1>33333333333333</h1>"
                        },
                        new Module
                        {
                            Id = 4,
                            Title = "Module 4",
                            ContentHtml = "<h1>4444444444444</h1>"
                        }
                    }
                }
            };
        }
    }
}
