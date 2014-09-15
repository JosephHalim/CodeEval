using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                int line = Convert.ToInt32(   reader.ReadLine());
                if (null == line)
                    continue;
               int[] sequence = new int[line+1] ;
                int sum = 0;
                for(int x = 0; x<=line;x++)
                {
                    if(x==0||x==1)
                    { sequence[x]=x;}
                    else
                    {
                        sequence[x] = sequence[x - 1] + sequence[x - 2];
                    }
                   if (x==line)
                   { Console.WriteLine(sequence[x]); }                                    
                }
            }
        Console.ReadLine();
    }
}