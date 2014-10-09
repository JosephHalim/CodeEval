using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Find_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine().Split('|');
                string listdata = data[0];
               var numberarray = data[1].Split(' ');
                for (int x = 1; x <= numberarray.Length - 1; x++ )
                {
                    Console.Write(listdata[Convert.ToInt32(numberarray[x])-1].ToString());
                }
                Console.WriteLine();
                reader.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
