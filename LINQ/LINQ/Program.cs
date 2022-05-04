using LINQ;
using System.Linq;

var books = new BookRepository().GetBooks();

//without Linq
Console.WriteLine("Without Linq -------------------------");
var cheapBooks = new List<Book>();
foreach (var book in books)
{
    if (book.Price < 10)
        cheapBooks.Add(book);
}

foreach(var book in cheapBooks)
    Console.WriteLine(book.Title + "-> price: " + book.Price + " EURO");

//with Linq
Console.WriteLine("With Linq ----------------------------");

//using LINQ query operators
var cheaperBooksQuery = 
    from b in books 
    where b.Price < 10 
    orderby b.Title 
    select b;

//using LINQ extention methods (these are better practice)
var cheapBooksLinq = books
    .Where(b => b.Price < 10)
    .OrderBy(b => b.Price);

foreach (var book in cheapBooksLinq)
    Console.WriteLine(book.Title + "-> price: " + book.Price + " EURO");


//you can use Linq select to select the property of an object
foreach (var title in books.OrderBy(b => b.Title).Select(b => b.Title))
    Console.WriteLine(title);


//get a single item (OrDefault returns null if none are found)
Console.WriteLine("single: " + books.SingleOrDefault(b => b.Title == "ASP.NET MVC"));

//get last item
Console.WriteLine("last: " + books.LastOrDefault());

//skip and take
var takenBooks = books.Skip(2).Take(3);
foreach (var book in takenBooks)
    Console.WriteLine("Take: " + book);

//count an IEnumerable
Console.WriteLine(takenBooks.Count());

//max price
Console.WriteLine(books.Max(b => b.Price));

//min price
Console.WriteLine(books.Min(b => b.Price));

//sum
Console.WriteLine(books.Sum(b => b.Price));

//average
Console.WriteLine(books.Average(b => b.Price));