namespace CSharpBasics;
using System;
public class Strings
{
    static void Main(String[] args)
    {
        string greeting = "Hello";
        string greeting2 = "Nice to meet you!";
        Console.WriteLine(greeting.ToUpper());
        Console.WriteLine(greeting2.Length);

        // String concatenation:
        string firstName = "John ";
        string lastName = "Doe";
        string FullName = string.Concat(firstName, lastName);
        Console.WriteLine(FullName);

    
    }
}
