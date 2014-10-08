using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecondtoLast
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
                while(!reader.EndOfStream)
                {
                    var data = reader.ReadLine().Split(' ');
                    Console.WriteLine(data[data.Length-2]);
                }
            Console.ReadLine();
        }
    }
}
