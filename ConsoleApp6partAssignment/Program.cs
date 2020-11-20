using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "the lion", "the tiger", "the bear", "the cat" };

            Console.WriteLine("Fill in the blank: The animal __________");
            string response = Console.ReadLine();

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i] + " " + response;
            }

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.ReadLine();

            //1.A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            //2.Save and execute your code.

            //3.A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 5);
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + 5);
            }

            Console.ReadLine();

            //1.A list of strings where each item in the list is unique.

            //2.Ask the user to input text to search for in the list.

            //3.A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.

            //4.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

            //5.Add code to the loop that stops it from executing once a match has been found.

            List<string> colors = new List<string>() { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("Name a color in the rainbow");
            string color = Console.ReadLine().ToLower();
            int colorIndex = 0;

            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i] == color)
                {
                    colorIndex = i + 1;
                    break;
                }
            }

            if (colorIndex > 0)
            {
                Console.WriteLine(color + " is number " + colorIndex + " in the Rainbow");
            }
            else
            {
                Console.WriteLine(color + " is not a ROYGBIV color.");
            }

            Console.ReadLine();

            //1.A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.

            //2.Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.

            //3.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

            //4.Save and execute your code.

            List<string> names = new List<string> { "john", "kelly", "jason", "john", "michael", "kelly" };

            Console.WriteLine("Who are you looking for?");
            string responseName = Console.ReadLine().ToLower();
            bool found = false;

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == responseName)
                {
                    int index = i + 1;
                    Console.WriteLine("Person " + index + " on the list is named " + responseName);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("There is no one named " + responseName + " on the list.");
            }
            Console.ReadLine();

            //1.Create a list of strings that has at least two identical strings in the list.

            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> moreNames = new List<string> { "ashley", "kevin", "josh", "ashley", "james", "kevin" };
            List<string> seenNames = new List<string>();

            foreach (string name in moreNames)
            {
                if (seenNames.Contains(name))
                {
                    Console.WriteLine("Current name is " + name + ". There is another person with that name on the list.");
                }
                else
                {
                    Console.WriteLine("Current name is " + name + ". This is the first time this name appears on the list.");
                }
                seenNames.Add(name);
            }

            Console.ReadLine();
        }
    }
}
