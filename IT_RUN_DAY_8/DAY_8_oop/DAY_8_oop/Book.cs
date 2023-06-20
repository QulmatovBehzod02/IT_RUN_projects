using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAY_8_oop
{
    public class Book
    {
        public string Title{ get; set; }
        public string Author { get; set; }
        public string Genre{ get; set; }

        public string GetInfo()
        {
            return $"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}";
        }
    }
    public class Paper
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }

        public string GetInfo()
        {
            return $"Date: {Date.ToString("yyyy-MM-dd")}\nName: {Name}\nPublisher: {Publisher}";
        }
    }

}
