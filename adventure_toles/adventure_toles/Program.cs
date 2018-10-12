using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventure_toles
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("You are walking down a road.\n You come to a crossroads. Do you go left or right?");
                string firstChoice = Console.ReadLine().ToLower();

                if (firstChoice == "left")
                {
                    Console.WriteLine("You chose wisely. This road looks safe. You start to get bored. Do you want to hum a tune? y/n ");
                    string secondChoice = Console.ReadLine().ToLower();
                    if (secondChoice == "y")
                    {
                        Console.WriteLine("You start to hum a tune and its so good the birds start to show up.\n Oh no the birds are going nuts!!");
                        Console.WriteLine("Oopsy poopsy, the birds pecked you to death.");
                        Console.WriteLine("Want to start over? y/n");
                        string rerun = Console.ReadLine().ToLower();
                        if (rerun == "yes" || rerun == "y")
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("bye");
                            break;
                        }
                    }

                    if (secondChoice == "no")
                    {
                        Console.WriteLine("Oh so you're the quiet and mysterious type? I dig it.\n Keep it real bro");
                        Console.WriteLine("Start Over? y/n");
                        string rerun = Console.ReadLine().ToLower();
                        if (rerun == "yes" || rerun == "y")
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("bye");
                            break;
                        }
                    }
                }

                if (firstChoice == "right")
                {
                    Console.WriteLine("Scary choice, this road is dark and creepy. You start to get the shakes. Do you want to run or walk?");
                    string secondChoice = Console.ReadLine().ToLower();
                    if (secondChoice == "run")
                    {
                        Console.WriteLine("You run all the way home. Wow, I didn't know you were such a chump");
                        Console.WriteLine("Start Over? y/n");
                        string rerun = Console.ReadLine().ToLower();
                        if (rerun == "yes" || rerun == "y")
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("bye");
                            break;
                        }
                    }
                    if (secondChoice == "walk")
                    {
                        Console.WriteLine("Nothing phases you, bro. That's why you're so smooth.");

                        Console.WriteLine("Start Over? y/n");
                        string rerun = Console.ReadLine().ToLower();
                        if (rerun == "yes" || rerun == "y")
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("bye");
                            break;
                        }

                    }
                }

                else
                {
                    Console.WriteLine("Not a valid answer, sucker.");
                    continue;
                }
            }
        }
    }
}
