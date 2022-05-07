using ExceptionHandling;

int count = 1;
while (true)
{
    //try codeblock
    try
    {
        Console.WriteLine($"SUM {DateTime.Now.ToString("yy:MM:")}{count.ToString().PadLeft(4, '0')}");
        Console.Write("Give a numerator: ");
        int num = int.TryParse(Console.ReadLine(), out int r) ? r : 0;
        Console.Write("Give a denomenator: ");
        int den = int.TryParse(Console.ReadLine(), out int n) ? n : 0;

        using (var calculator = new Calculator())
        {
            Console.WriteLine($"{num} divided by {den} is {calculator.Divide(num, den)}");
        }
        count++;
    }
    //less generic exception
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: Cannot divide by 0.");
    }
    //generic exception
    catch (Exception ex)
    {
        throw new CustomException("Sorry, an unexpected error occured.", ex);
    }
    //finally dispose active resources if needed (best practice is 'using')
    finally
    {
        Console.WriteLine("\n");
    }
}