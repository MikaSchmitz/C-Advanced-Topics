using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "ADO.NET Step by Step", Price = 5},
                new Book() { Title = "ASP.NET MVC", Price = 9.99},
                new Book() { Title = "ASP.NET Web API", Price = 12},
                new Book() { Title = "C# Advanced Topics", Price = 13},
                new Book() { Title = "C# Advanced Topics 2", Price = 9},
            };
        }
    }
}
