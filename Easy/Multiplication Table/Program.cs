using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=1;x<13;x++)
            {
                for(int y = 1 ; y<13; y++)
                {
                    Console.Write(String.Format("{0,4}",y*x));
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
