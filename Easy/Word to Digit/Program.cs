using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordtoDigitP
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
              var data =  reader.ReadLine().ToLower().Split(';');
                foreach(var number in data)
                {
                    switch(number)
                    {
                        case "zero":
                            Console.Write("0");
                            break;
                        case "one":
                            Console.Write("1");
                            break;
                        case "two":
                            Console.Write("2");
                            break;
                        case "three":
                            Console.Write("3");
                            break;
                        case "four":
                            Console.Write("4");
                            break;
                        case "five":
                            Console.Write("5");
                            break;
                        case "six":
                            Console.Write("6");
                            break;
                        case "seven":
                            Console.Write("7");
                            break;
                        case "eight":
                            Console.Write("8");
                            break;
                        case "nine":
                            Console.Write("9");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
