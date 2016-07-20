using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"Enter 1 for Student Add {Environment.NewLine} 2 for Viewing Students {Environment.NewLine} Any other Key for Exit");
                string choice = Console.ReadLine().Trim();
                string filePath = ConfigurationManager.AppSettings["FilePath"];
                if (choice == "1")
                {
                    Console.WriteLine("Enter Student Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Student Id");
                    string id = Console.ReadLine();
                    
                    Console.WriteLine(filePath);
                    string record = $"{name} {id}{Environment.NewLine}";  //name+" "+id
                    File.AppendAllText(filePath, record);
                }
                else if (choice=="2")
                {
                    File.ReadAllText(filePath);
                }
                else 
                {
                    break;
                }

            }
            


        }
    }
}
