using ExtentionMethods;

string post = "A very long blog post for social media";
//the 'Shorten' method can be used because the StringExtentions class extends on the string class (using static class and 'this String' as a parameter)
var shortenedPost = post.Shorten(5);
Console.WriteLine(shortenedPost);

//most of the time you will be using existing extention methods like Linq
IEnumerable<int> numbers = new List<int>() { 1, 50, 32, 66, 85, 4, 52 };
var maxNumber = numbers.Max();
Console.WriteLine(maxNumber);