using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(@"C:\Users\Joey\Desktop\Multiple.txt"   ))
        while (!reader.EndOfStream)
        {
            string[] line = reader.ReadLine().Split(',');
            if (null == line)
                continue;
            int counter = 1;
            int largest = 0;
            do{
                 largest =  Convert.ToInt32(line[1]) * counter;
                 counter++;
                
            }
            while(Convert.ToInt32(line[0])>largest);
          
            Console.WriteLine(largest);
           
        }
        Console.ReadLine();
    }
}