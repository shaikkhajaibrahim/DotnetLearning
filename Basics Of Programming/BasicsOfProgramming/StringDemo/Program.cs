using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2,3,4,5
            string s=string.Empty;
            //never use string operations in loops
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            bool isFirst = true;
            for(int index=1;index<=100;index++)
            {
                if(!isFirst)
                {
                    sb.Append("," + index);
                }
                else
                {
                    sb.Append(index);
                    isFirst = false;
                }
                
            }

            Console.WriteLine(sb.ToString());

            string s1 = "Hello";
            string s2 = s1;
            Console.WriteLine("Comparting S1 to S2");
            Console.WriteLine(s1==s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine("Comparting S1 to S3");
            object s3 = new string(new[] { 'H', 'e', 'l', 'l','o' });
            object s4 = "Hello";

            Console.WriteLine(s1==s3);
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine("Comparting S1 to S4");
            Console.WriteLine(s1 == s4);
            Console.WriteLine(s1.Equals(s4));

            string s5 = "";
            string s6=null;
            string s7 = "           ";

            if(
                s5!=null && 
                (
                    !s5.Equals(string.Empty) && 
                    !s5.Trim().Equals(string.Empty)
                )
              )
            {
                Console.WriteLine($"{s5} is not Empty");

            }
            else
            {
                Console.WriteLine($"{s5} is empty");
            }

            if(!string.IsNullOrEmpty(s6))
            {
                if(!string.IsNullOrEmpty(s6.Trim()))
                {
                    Console.WriteLine(s6+" is not empty");
                }
                Console.WriteLine(s6 + " is empty");

            }
            else
            {
                Console.WriteLine(s6 + " is empty");
            }

            if(string.IsNullOrWhiteSpace(s7))
            {
                Console.WriteLine($"{s7} is empty");
            }
            else
            {
                Console.WriteLine($"{s7} is not empty");
            }

            s7 = "Shiva";
            int indexOf=s7.IndexOf('S');
            Console.WriteLine( s7.Contains("iva"));

            s6 = "shiva";
            Console.WriteLine(s6.Equals(s7,StringComparison.OrdinalIgnoreCase));
            //s7 = "సుల్తాన్";

            List<int> numbers = new List<int>();
            for(int index=1;index<=100;index++)
            {
                numbers.Add(index);
            }
            //Environment.NewLine;
            string joinedString = String.Join(",", numbers);
            Console.WriteLine(joinedString);
            String[] numberStrings=joinedString.Split(',');

        }
    }
}
