using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_8_oop
{
    public class User
    {
        public string Name{ get; set; }
        public string LastName { get; set; }
        public uint Id{ get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class BookReader : User
    {
        public List<Book> FavoriteBooks { get; set; }

        public BookReader()
        {
            FavoriteBooks = new List<Book>();
        }
    }
    public class Librarian : User
    {
        public decimal Salary { get; set; }
    }




}
