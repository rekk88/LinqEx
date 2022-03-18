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
            string toOrder = "is2 Thi1s T4est 3a";
            string[] splitted = toOrder.Split(" ");
            int[] numbers = { };
            //var sorted = splitted.OrderBy(item => int.TryParse(item, out int n));
            foreach (var item in splitted)
            {
                int resultNumber = int.Parse( Regex.Match(item, @"\d+").Value);
                numbers-(resultNumber);
            }

            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    if(int.TryParse(splitted[i], out int n))
            //    {
            //        numbers.Append(n); //n rappresenta la singola parola e l'indice in cui si trova il suo ordinamento
            //    }
            //}
            //var ordered = splitted.OrderBy(item => )
        }

        static string Order(string words)
        {


            return words;
        }
        
        static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var retList = new List<T>();
            foreach (var element in iterable)
            {
                if (!element.Equals(retList.LastOrDefault())) 
                {
                    retList.Add(element);
                }
            };
            return retList;
        }


    }
}
