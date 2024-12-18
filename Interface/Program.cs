﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void TestAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            T divide = a.Divide(b);
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b); // ab
            curr = curr.Add(curr); // ab + ab = 2ab

// I'm not sure how to create constant factor "2" in more elegant way,
// without knowing how IMyNumber is implemented
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }
        static void Main(string[] args)
        {
            /*
            TestAPlusBSquare(new MyFrac("1/3"), new MyFrac(1, 6));
            TestAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            //sorting
            */

            List<MyFrac> nums = new List<MyFrac>
            {
                new MyFrac(2,-36),
                new MyFrac(1,7)
            };
            nums.Sort();
            Console.WriteLine("Input data after sorting:");
            foreach(MyFrac num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
