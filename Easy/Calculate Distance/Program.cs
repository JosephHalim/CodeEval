using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CalculateDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 =0;
            var y1=0;
            var x2 = 0;
            var y2 = 0;
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                
                var data = reader.ReadLine();
                Regex rgx = new Regex(@"[\+-]?\d+");
                MatchCollection stuff = rgx.Matches(data);
                Console.WriteLine(Math.Sqrt(Math.Pow((Convert.ToInt32(stuff[2].Value) - Convert.ToInt32(stuff[0].Value)), 2) + Math.Pow((Convert.ToInt32(stuff[3].Value) - Convert.ToInt32(stuff[1].Value)), 2)));
            }
            Console.ReadLine();
        }
    }
}
