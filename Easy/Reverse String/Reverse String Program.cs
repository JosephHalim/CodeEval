
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
            string[] line = reader.ReadLine().Split(' ');
            int counter=0;
            if (null == line)
                continue;
            do 
            {
                string temp = null;
                temp = line[counter];
                line[counter] = line[line.Length - counter-1];
                line[line.Length-1 - counter] = temp;
                counter++;
            } while (line.Length - counter > counter);
            int x = 0;
            do
            {
                Console.Write(line[x] + ' ');
                x++;
            } while (x < line.Length);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
    
}