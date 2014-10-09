using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine().Split(' ');
                foreach(var text in data)
                {
                    Console.Write(text.Substring(0, 1).ToUpper());
                    Console.Write(text.Substring(1, text.Length-1));
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
