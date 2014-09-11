using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Prime_Under_1000
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var t = 0;
            int largeint=0;
            for(int x =0;x<=1000; x++)
            {
               string split = x.ToString();
              var length= split.Length;
              if ( isPrime(x) == true)
              {
                  if (length == 1)
                  {
                      largeint = x;
                  }
                  else if (length == 2)
                  {

                      if (split.Substring(t, 1) == split.Substring(t + 1, 1))
                      {
                          largeint = x;
                      }
                  }
                  else if (length == 3)
                  {
                      if (split.Substring(t, 1) == split.Substring(t + 2, 1))
                      {
                          largeint = x;
                      }
                  }
                  else if (length == 4)
                  {
                      if (split.Substring(t, 1) == split.Substring(t + 3, 1) && split.Substring(t + 1, 1) == split.Substring(t + 2, 1))
                      {
                          largeint = x;
                      }
                  }
              }    
            }
            Console.WriteLine(largeint);
            }
        private static bool isPrime(int num)
        {
            for(int i=3;i<num;i+=2)
            {
                if (num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        }
    }

