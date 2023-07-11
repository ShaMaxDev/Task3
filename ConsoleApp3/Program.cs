using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();
            Console.WriteLine("What is yor favorite pet?");
            string userPet = Console.ReadLine(); 
            Console.WriteLine("Your name is " + userName + ", you are " + userAge + " years old, and " + userPet + " is your favorite pet.");
        }
    }
}
