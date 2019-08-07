using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMakerApp
{
    class ChoiceInput
    {
        public void Choices()
        {
            Console.WriteLine("Enter a number of choices you want me to pick from:");

            int x = Convert.ToInt32(Console.ReadLine());
            string[] choices = new string[x];
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"Enter choice {i + 1}:");
                choices[i] = Console.ReadLine();
            }
            RandomDecision(choices);
        }
        public void RandomDecision(string[] choices)
        {
            Random rand = new Random();
            int index = rand.Next(choices.Length);
            Console.WriteLine($"Your randomly chosen decision is: {choices[index]}");
            Console.ReadLine();
        }
    }
}

