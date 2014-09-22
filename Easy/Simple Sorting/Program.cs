using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\Joey\Documents\GitHub\CodeEval\Easy\Simple Sorting\Document.txt"))
            while(!reader.EndOfStream)
            {
                var temp =reader.ReadLine().Split(' ');
                decimal[] temp2 = new decimal[temp.Length];
                for (int x = 0; x < temp.Length; x++ )
                {
                    if(temp[x].Substring(0,1).Contains('-'))
                    {
                        temp2[x]=Convert.ToDecimal(temp[x].Substring(1,temp[x].Length-1)) * -1;
                    }
                    else
                    {
                        temp2[x] = Convert.ToDecimal(temp[x]);
                    }      
                }
                Array.Sort(temp2);  
                for(int x= 0; x< temp2.Length;x++)
                {
                    Console.Write(temp2[x].ToString() + ' ');
                }
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
