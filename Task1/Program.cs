using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Squares(4, 17));
            Console.ReadLine();
        }
        public static int Squares(int A, int B)
        {
            if (A > B)
                throw new System.ArgumentException("arg A must be <= B");
            return (int)Math.Sqrt(B) - (int)Math.Sqrt(A - 1);
        }
    }
}
