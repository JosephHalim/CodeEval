using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultipleList
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                var twolist = reader.ReadLine().Split('|');
                var listone = twolist[0].Split(' ');
                var listtwo = twolist[1].Split(' ');
                for (int x = 0; x < listtwo.Length-1; x++)
                {
                    int data = Convert.ToInt32(listone[x]);
                    int data2 = Convert.ToInt32(listtwo[x+1]);
                    Console.Write(data*data2);
                    if (x != listtwo.Length - 1)
                    {
                        Console.Write(' ');
                    }

                }


                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
