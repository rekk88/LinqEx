using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    { 
      
        static void Main(string[] args)
        {
            string str = "AAAABBBCCDAABBB";
           
            List<string> filteredValues = new List<string>();

            //int[] numbers = { 1, 2, 2, 3, 3 };
            int savePosition = 0, i = 0;
            string savedChar = string.Empty;
            for (i = savePosition; i < str.Length; i++)
            {
              
                if (i+1 < str.Length)
                {
                    if (str[i] == str[i + 1])
                    {
                        for (int j = i + 2; j < str.Length; j++)
                        {
                            if (str[i] != str[j])
                            {
                                savePosition = j-1;
                                
                                break;
                            }
                        }
                        if(i <= savePosition) 
                        {
                            savedChar = string.Concat(str[i..savePosition].Distinct().TakeWhile(char.IsLetter));
                        }
                        
                        i = savePosition;
                        filteredValues.Add(savedChar.ToString());
                    }
                }
                
            }

            Console.WriteLine("ciao");
        }
    }
}
