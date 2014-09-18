using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Recovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            using(StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {              
                string[] line = reader.ReadLine().Split(';');
                string[] word = line[0].Split(' ');
                string[] place = line[1].Split(' ');
                var numberarray = new List<int>();
               
                for (int x = 0; x < word.Length+1;x++ )
                {             
                    numberarray.Add(x);
                }
            
                for (int x = 0; x < word.Length; x++)
                    {
                        try
                        {
                            data.Add(Convert.ToInt32(place[x]), Convert.ToString(word[x]));
                            numberarray.Remove(Convert.ToInt32(place[x]));                       
                        }
                        catch (System.IndexOutOfRangeException)
                        {
                            var temp = numberarray.ToArray();
                            data.Add(Convert.ToInt32(temp[1]), Convert.ToString(word[x]));
                        }
                    }
              var items = from keyvalue in data
                  orderby keyvalue.Key ascending
                      select keyvalue;
               
                foreach(KeyValuePair<int,string> key in items)
                {
                    Console.Write(key.Value + ' ');
                }
                Console.WriteLine();
                Array.Clear(word, 0, word.Length);
                Array.Clear(place, 0, place.Length);
                data.Clear();
            }
            Console.ReadLine();
        }   
    }
}

