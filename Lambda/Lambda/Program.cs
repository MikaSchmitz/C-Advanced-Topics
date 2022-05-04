using System;
using Lambda;

//default way of getting the square of an int
static int Square(int number)
{
    return number * number;
}
Console.WriteLine(Square(5));


//get square using lambda (anonymous method)
// args => expression
//using a delegate for lambda: the first value represents the given type, the second is the return type <int, int>
Func<int, int> square = number => number * number;

Console.WriteLine(square(5));


//no arguments=
// () => ...

//one argument=
// x => ...

//multiple arguments=
// (x, y, z) => ...

const int factor = 5;

Func<int, int> multiplier = n => n * factor;

var result = multiplier(10);
Console.WriteLine(result);



//get all books
var books = new BookRepository().GetBooks();

//use lambda operator for getting all books where price < 10
foreach(var book in books.FindAll(b => b.Price < 10))
{
    Console.WriteLine(book.Title);
}

