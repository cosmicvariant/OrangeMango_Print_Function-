using System;

class OrangeMango
{
    static void Main(string[] args)
    {
        PrintNumbersWithConditions();
    }

    static void PrintNumbersWithConditions()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("OrangeMango");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Orange");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Mango");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

