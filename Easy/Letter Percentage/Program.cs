using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LetterPercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while(!reader.EndOfStream)
            {
                string lowercase = "abcdefghijklmnopqrstuvwxyz";
                float numlower = 0;
                float numupper = 0;
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                for(int x = 0; x<line.Length; x++)
                {
                 
                    if (lowercase.Contains(line.Substring(x,1)) == true)
                    {
                        
                        numlower++;
                    }
                    else
                    {
                        numupper++;
                    }
                }
               
                Console.WriteLine("lowercase: " + ((numlower / (numlower + numupper))*100).ToString("F02") + " uppercase: " + ((numupper / (numlower + numupper))*100).ToString("F02"));

            }
            Console.ReadLine();
        }
    }
}
