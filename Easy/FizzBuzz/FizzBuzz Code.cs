using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string[] line = reader.ReadLine().Split(' ');
            
            if (null == line)
                continue;
            int firstnumber = Convert.ToInt32(line[0]);
            int secondnumber = Convert.ToInt32(line[1]);
            int end = Convert.ToInt32(line[2]);
            for(var x=1; x<=end;x++)
            {
                if (x % firstnumber == 0 && x % secondnumber == 0)
                    Console.Write("FB");
                else if (x % firstnumber == 0)
                    Console.Write("F");
                else if (x % secondnumber == 0)
                    Console.Write("B");
                else
                    Console.Write(x);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}