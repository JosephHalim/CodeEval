using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x<100; x+=2)
            {
                if(x%2!=0)
                {
                    Console.WriteLine(x);   
                }
            }
            Console.ReadLine();
        }
    }
}
