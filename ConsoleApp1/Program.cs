using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Reizināšanas tabula 10x10");
        Console.WriteLine(" |\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10");


        Console.WriteLine("___________________________________________________________________________________");

      
        for (int i = 1; i <= 10; i++)
        {
            Console.Write( + i + "|\t");

            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;
                Console.Write(result + "\t");
            }

            Console.WriteLine(); 
        }
    }
}

