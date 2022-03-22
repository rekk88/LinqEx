using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int n = 1652;
            string numbers = n.ToString();
            int[] rtnNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                rtnNumbers[i] = int.Parse(numbers[i].ToString());
            }


            //int digitsNumber = (int)Math.Floor(Math.Log10(n) + 1);

            double sum = 0;
            for (int i = 0; i < rtnNumbers.Length; i++)
            {
                sum += Math.Pow(rtnNumbers[i], rtnNumbers.Length);
            }
            if (sum == n)
            {
                //return true
            }
            else
            {
                //return false
            }
            Console.WriteLine(sum);
        }
    }

     
        
    


    
}
