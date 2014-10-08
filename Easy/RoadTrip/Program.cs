using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RoadTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = File.OpenText(@"C:\Users\Joey\Documents\GitHub\CodeEval\Easy\RoadTrip\RoadTrip.txt"))
            while(!reader.EndOfStream)
            { 
             
               List<int> cities = new List<int>();
                var splitcities = reader.ReadLine().Split(';');
                for(int x = 0; x<splitcities.Length-1; x++)
                {
                    var splitdistance = splitcities[x].Split(',');
                    cities.Add(Convert.ToInt32(splitdistance[1]));
                }
              /*  var sort = from data in cities //Causes Runtime Slowdown
                           orderby data ascending
                           select data;*/
                cities.Sort();
                int distance = 0;
                int sortnum = 0;
                foreach(var data in cities)
                {
                    
                    Console.Write(data-distance);
                    sortnum++;
                    if (sortnum != cities.Count())
                    { Console.Write(','); }
                    distance = data;
                }
                cities.Clear();
                Array.Clear(splitcities,0,splitcities.Length);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
