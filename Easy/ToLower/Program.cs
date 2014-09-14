
using System.IO;
using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine().ToLower();
            if (null == line)
                continue;
            Console.WriteLine(line);
            // do something with line
        }
        Console.ReadLine();
    }
}