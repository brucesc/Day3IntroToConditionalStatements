using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        int weird = 0;
        int notWeird = 0;
       
        if (N % 2 != 0)
        {
            weird += 1;
        }
        else if (N % 2 == 0 && 2 <= N && N < 5)
        {
            notWeird += 1;
        }
        else if (N % 2 == 0 && 6 <= N && N <= 20)
        {
            weird += 1;
        }
        else if (N % 2 == 0 && 20 < N)
        {
            notWeird += 1;
        }

        if (weird == 1)
        {
            Console.WriteLine("Weird");
        }
        else
        {
            Console.WriteLine("Not Weird");
        }
        Console.ReadKey();

    }
}
