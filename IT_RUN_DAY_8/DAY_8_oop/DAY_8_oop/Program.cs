using DAY_8_oop;
 
LibraryService libraryService = new LibraryService();

Book book1 = new Book { Author="man", Genre="namedonam", Title="yagonchi"};
Book book2 = new Book { Author = "tu", Genre="farqash ne", Title = "title" };

libraryService.AddBook(book1);
libraryService.AddBook(book2);

var resSearchByTitle= libraryService.SearchByTitle("yagonchi");

var resSearchByAuthor = libraryService.SearchByAuthor("man");
/*
foreach (Book book in resSearchByAuthor)
{
    Console.WriteLine(book.Title);
}
*/


BookReader bookReader = new BookReader
{
    Name = "Behzod",
    LastName = "Qulmatov",
    Id = 1,
    UserName = "behzod_1800",
    Password = "secret"
};

Librarian librarian = new Librarian
{
    Id = 1,
    Name = "Marifat",
    LastName = "Yuldosheva",
    UserName = "mYuldosheva",
    Password = "secret123",
    Salary = 1400
};

Book book = new Book
{
    Author = "Sandro",
    Genre="Science",
    Title="Saadur"
};

Paper paper = new Paper
{
    Date = DateTime.Now,
    Name="Sughd",
    Publisher="sughd_tv"
};

var infoBook = book.GetInfo();
var infoPaper= paper.GetInfo();

Console.WriteLine(infoBook);
Console.WriteLine(infoPaper);

/*
bookReader.FavoriteBooks.Add(new Book { Author = "John Sharp", Genre = "Program", Title="C#" });
bookReader.FavoriteBooks.Add(new Book { Author = "Abu-Ali Ibni Sino", Genre = "Tib", Title = "Qonuni Tib" });

foreach (var book in bookReader.FavoriteBooks)
{
    Console.WriteLine($"Author: {book.Author} \n Genre: {book.Genre} \n Title: {book.Title}");
}
*/