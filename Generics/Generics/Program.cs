using System;
using Generics;

//** GENERICS **
//create a generic list of books
var books = new GenericList<Book>();
books.Add(new Book() { Title = "Rupsje Nooitgenoeg" });

//create a generic dictionary of books
var books2 = new GenericDictionary<string, Book>();
books2.Add("Boek 1", new Book() { Title = "Rupsje Nooitgenoeg" });

//prebuild generic lists are most commonly used, examples are:
var books3 = new List<Book>();
var books4 = new Dictionary<string, Book>();



//** CONSTRAINTS **
// constraints allow classes to be restrictive of certain input types
//the class constraint only allows input types that are comparable
var compare = new Constraints<int>();
var higherNumber = compare.Max(5, 10);

//Nullable only allows input types that can be Null
var number = new Generics.Nullable<int>();
Console.WriteLine("Has value ? " + number.HasValue);
Console.WriteLine("Value: " + number.GetValueOrDefault());

//Nullable always exists in .net as System.Nullable
