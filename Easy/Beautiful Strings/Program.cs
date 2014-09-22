using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BeautifulStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            using (StreamReader reader = File.OpenText(args[0]))
            
            while(!reader.EndOfStream)
            {
                string isalpha = "abcderfghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string line = reader.ReadLine();
                for (int x = 0; x < line.Length; x++)
                {
                    string character = line.Substring(x, 1).ToLower();
                    if (isalpha.Contains(character) == true)
                    {
                        try
                        {
                            data.Add(character, 1);
                        }
                        catch
                        {
                            int values = data[character];

                            data.Remove(character);
                            data.Add(character, ++values);
                        }
                    }
                }
                var list = from d in data orderby d.Value descending
                           select d;

                int decrement = 26;
                int sum = 0;
                foreach( var values in list)
                {
                   sum +=  values.Value * decrement;
                    decrement--;
                }
                data.Clear();
                Console.WriteLine(sum);
            }

            Console.ReadLine();
        }
    }
}
