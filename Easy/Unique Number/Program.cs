using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniqueElement
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader= File.OpenText(args[0]))
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(',');
                    string[] unique = new string[line.Length];
                    List<string> data = new List<string>();
                    for(int x = 0; x<line.Count();x++)
                    {
                        if(data.Contains(line[x])==false)
                        {
                         data.Add(line[x]);
                        }
                    }
                    for(int x = 0 ; x<data.Count;x++)
                    {
                        if (x == data.Count - 1)
                        {
                            Console.Write(data[x]);
                        }
                        else
                        {
                            Console.Write(data[x] + ',');
                        }
                    }
                    Console.WriteLine();


                }
            Console.ReadLine();
        }
    }
}
