using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int prime = 0;
        int count = 2;
        do
        {
            int temp = isPrime(count);
            if (temp > 0)
            {
                sum += temp;
                prime++;
            }
            count++;
        } while (prime != 1000);
        Console.WriteLine(sum);
    }
    private static int isPrime(int num)
    {

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return 0;
            }
        }
        return num;


    }

}