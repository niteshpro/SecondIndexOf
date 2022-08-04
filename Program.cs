//how to find the second index of a character (this solution finds the second index of '-'). C# code
using System;
class Program
{
    public static void Main()
    {
        var str = "Hi-this-solution-gives-second-index-of-a-character";

        Console.WriteLine("Index of second '-' is: "+SecondIndexOf(str));

    }
    public static int SecondIndexOf(string str)
    {
        return str.IndexOf('-', str.IndexOf('-') + 1);
    }
}