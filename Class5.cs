using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Class5
    {
                    // full pyramid of *   
        static void Main(string[] args)
        {
            int k=0, space;
            Console.WriteLine("Enter the row");
            int row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;++i,k=0)
            {
                for(space=1;space<=row-i;++space)
                {
                    Console.Write("  ");
                }
            while(k != 2*i-1)
                {
                    Console.Write("* ");
                    ++k;
                }
                Console.WriteLine();

            }
        }
    }
}
