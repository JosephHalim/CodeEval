using System;
using System.IO;
using System.Collections.Generic;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                   
                    int sum = 0;
                    for(int x=0; x<line.Length;x++)
                    {
                        sum += Convert.ToInt32(line.Substring(x,1));
                    }
                    Console.WriteLine(sum);
                }
            Console.ReadLine();
        }
    }
}
