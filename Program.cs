using System;

class MainClass
{

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    public static void Main(string[] args)
    {
        decimal f = Factorial(20);
        Console.WriteLine(f.ToString());
    }
}
