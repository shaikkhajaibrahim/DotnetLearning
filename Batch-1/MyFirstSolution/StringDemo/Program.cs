using System;
using System.Text;

namespace StringDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter any text");
            String input = Console.ReadLine();
            Console.WriteLine("Enter subtext to be searched");
            String searchKey = Console.ReadLine();

            if(input.ToUpper().Contains(searchKey.ToUpper()))
            {
                Console.WriteLine("Match Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("Enter the text");
            string input2 = Console.ReadLine();

            if(input.Equals(input2,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Inputs are equal");
            }
            else
            {
                Console.WriteLine("Inputs are not equal");
            }

            //name= Ram  Hello Ram!. How are you doing
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            string formattedText = "Hello " + name + "!. How are you doing";
            Console.WriteLine(formattedText);
            string formattedTextOtherWay = $"Hello {name}!. How are you doing";
            Console.WriteLine(formattedTextOtherWay);
            string formattedTextOlderWay = string.Format("Hello {0}!. How are you doing", name);
            Console.WriteLine(formattedTextOlderWay);
            // Rama,Krishna,Hai
            // Rama;Krishna;Hai

            Console.WriteLine("Enter names separated by ,");
            string names = Console.ReadLine();
           // if(names!=null && names!="" && names.Trim()!="")
           if(!string.IsNullOrWhiteSpace(names))
            {
                String[] nameArray = names.Split(',');
                Console.WriteLine(string.Join(";", nameArray));

                //Replacing characters
                Console.WriteLine(names.Replace(',', ';'));
            }
            string s = string.Empty;
            StringBuilder sb = new StringBuilder();
            while(true)
            {
                Console.WriteLine("Enter regno");
                string inputForReg = Console.ReadLine();
                sb.AppendLine(inputForReg);
                if(inputForReg=="0")
                {
                    break;
                }
                
            }
            
        }
    }
}
