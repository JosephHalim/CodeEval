using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine().Split(',');
                int multiple = Convert.ToInt32(data[0]) / Convert.ToInt32(data[1]);
              Console.WriteLine( Convert.ToInt32(data[0]) - (multiple * Convert.ToInt32(data[1])));

            }
            Console.ReadLine();
        }
    }
}
