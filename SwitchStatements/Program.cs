using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Nerd! Just kidding.... I love math too.");
                    break;
                case "Science":
                    Console.WriteLine("Bill Nye The Science Guy would be happy to hear your choice.");
                    break;
                case "English":
                    Console.WriteLine("So, you must be one of them Book Worms, eh?");
                    break;
                case "Social Studies":
                    Console.WriteLine("BORINGGGGGG. Okay, just kidding. Maybe");
                    break;
                case "History":
                    Console.WriteLine("That's awesome! Maybe you can tutor me... History class was when I took naps. Sorry teacher.");
                    break;
                case "Art":
                    Console.WriteLine("Finally, a creative human! I too love the art classes.");
                    break;
                default:
                    Console.WriteLine($"Hmmmm.... I haven't heard of {subject}, however, it sounds intriguing!");
                    break;


                

            }

        }
    }
}
