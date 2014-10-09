using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Swap_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                string data = reader.ReadLine();
                for(int x = 0; x<=data.Length-1; x++)
                {
                   
                    if(Char.IsUpper(data.Substring(x,1),0) == true)
                    {
                        Console.Write(data.Substring(x, 1).ToLower());
                    }
                    else
                    {
                        Console.Write(data.Substring(x, 1).ToUpper());
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
