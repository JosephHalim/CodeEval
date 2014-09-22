using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcderfghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            using (StreamReader reader = File.OpenText(args[0]))
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine().ToLower();
                    bool isCapital = false;
                    if(null == line)
                        continue;
                    for(int x = 0; x<line.Length; x++)
                    {
                        var temp = line.Substring(x, 1);
                        if(data.Contains(line.Substring(x,1)) == true )
                        {
                            if(isCapital == false)
                            {
                                var text = line.Substring(x,1).ToUpper();
                               
                           string temp2 =  line.Remove(x, 1);
                           line = temp2.Insert(x, text);
                                
                                isCapital = true;
                            }
                            else
                            {
                                line.Substring(x,1).ToLower();
                                isCapital = false;
                            }
                        }
                    }
                    Console.WriteLine(line);
                   
                }
            Console.ReadLine();
        }
    }
}
