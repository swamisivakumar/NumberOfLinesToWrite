using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLinesToWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[]  widths = { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
          string   s = "bbbcccdddaaa";
          var val= NumberOfLines(widths, s);
          Console.WriteLine(val[0].ToString()+"  " + val[1].ToString());
          Console.ReadLine(); 
        }

        public static int[] NumberOfLines(int[] widths, string s)
        {
            int counter = 0;
            int stringCount = 0; 
            var strChars = s.ToCharArray().Select(x => (x.GetIndexatoz()-97)).ToArray();
            int[] array= new int[2];
            for (int i = 0; i < strChars.Length-1; i++)
            {
                var index = (int)(strChars[i]);
                var nexIndex= (int)(strChars[i+1]);
                counter += widths[index];

                if (counter + widths[nexIndex] > 100)
                {
                    stringCount += 1;
                    counter = 0;
                }
            }       
            if (counter >= 0)
            {
                stringCount += 1;
                counter += widths[ (int)strChars[strChars.Length-1]];
            }
           
            array[0] = counter;
            array[1] = stringCount;
            return array;
        }


    }
}
