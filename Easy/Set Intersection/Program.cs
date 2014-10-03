using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SetIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\Joey\Documents\GitHub\CodeEval\Easy\Set Intersection\Document.txt"))
            while(!reader.EndOfStream)
            {
                string[] twolist = reader.ReadLine().Split(';');
                var listone = twolist[0].Split(',');
                var listtwo = twolist[1].Split(',');
                int count = 0;
                List<int> listadd = new List<int>();
                foreach(var data in listone)
                {  
                    if(listtwo.Contains(data)==true)
                    {
                        if(count==0)
                        {
                        Console.Write(data);
                        count++;
                        }
                        else{
                            Console.Write(',' + data);
                        }      
                    }
                }                  
                Console.WriteLine();            
                Array.Clear(listone, 0, (listone.Count()));
                Array.Clear(listtwo, 0, (listtwo.Count()));
            }
            Console.ReadLine();
            }
    }
}
