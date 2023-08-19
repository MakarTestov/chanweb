using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComScience.Web.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ContentHTML { get; set; }

        public string ImgPath { get; set; }

        public string ImgAlt { get; set; }

        public string Tag { get; set; }

        public DateTime DatePublication { get; set; }
    }
}
