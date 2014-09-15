using System;
using System.IO;
using System.Collections.Generic;
namespace SumInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            using (StreamReader reader = File.OpenText(@"C:\Users\Joey\Desktop\SumInteger.txt"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    sum += Convert.ToInt32(line);
                }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        
    }
}
