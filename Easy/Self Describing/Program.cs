using System;

using System.IO;

namespace SelfDescribing
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                int answer = 0;
                string line = reader.ReadLine();
             for(int x = 0; x<line.Length-1; x++)
             {
                 int numberfound = 0;
                 string numbertofind = line.Substring(x, 1);
                 string number = x.ToString(); ;
                 for(int y=0;y<line.Length;y++)
                 {
                     if(line.Substring(y,1)==number)
                     {
                         numberfound++;
                     }
                 }
                 if (numberfound.ToString()!=numbertofind.ToString())
                 {
                     answer = -1;
                     break;
                 }
             }
               if(answer==-1)
               {
                   Console.WriteLine("0");
               }
               else
               {
                   Console.WriteLine("1");
               }
            }
            Console.ReadLine();
        }
    }
}
