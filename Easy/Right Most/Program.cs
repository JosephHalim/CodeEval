using System;
using System.IO;

namespace RightMost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                string[] file = reader.ReadLine().Split(',');
                Console.WriteLine(file[0].LastIndexOf(file[1]));
            }
            Console.ReadLine();
        }
    }
}
