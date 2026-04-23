using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Methods
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   
            Console.WriteLine(txt.ToLower());
            
            //String concatination
            string firstName = "Shravani ";
            string lastName = "Magdum";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            string firstName1 = "Meghana";
            string lastName1 = "Musale";
            string name1 = $"My full name is: {firstName1} {lastName1}";
            Console.WriteLine(name1);

            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("e"));


        }
    }
}
