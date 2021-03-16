using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Inheritance
{
   
        public class Program                 //DO NOT CHANGE the name of class 'Program'
        {
            public static void Main(string[] args)   //DO NOT CHANGE 'Main' Signature
            {
                //Implement the code here
                char c;
                int i, j, k, n, m, l = 1;
                Console.WriteLine("Enter any symbol $ or * or @");
                c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter number of repeats  :");
                n = Convert.ToInt32(Console.ReadLine());
                m = ((n + 1) / 2);
                for (i = 1; i <= m; i++)
                {
                    for (k = i; k < m; k++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= l; j++)
                    {
                        Console.Write(c);
                    }
                    for (k = i; k < m; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    l = l + 2;
                }
            }
        }
    
}
