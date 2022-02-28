using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                char input = char.Parse(Console.ReadLine());
                arr[i] = input;
            }
            int CountOfE = 0, CountOfQ = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == '?') CountOfQ++;
                if (arr[i] == '!') CountOfE++;
            }
            Console.WriteLine("Q:" + CountOfQ);
            Console.WriteLine("E:" + CountOfE);
            // question 2
            string[] Card = new string[16];
            Random rand = new Random();
            for (int i = 0; i < Card.Length; i++)
            {
                int gotNum = rand.Next(1, 4);
                string sym = "";
                switch (gotNum) {
                    case 1:
                        sym = "1";
                        break;
                    case 2:
                        sym = "2";
                        break;
                    case 3:
                        sym = "x";
                        break;
                }
                Card[i] = sym;
            }
            for (int i = 0; i < Card.Length; i++)
            {
                Console.Write(" " + Card[i] + " ");
            }
            Console.WriteLine("");
            string[] userCard = new string[16];
            for (int i = 0; i < Card.Length; i++)
            {
                userCard[i] = Console.ReadLine();
            }
            // ok now check how many correct
            int AmtCorrect = 0;
            for (int i = 0; i < Card.Length; i++)
            {
                if (Card[i] == userCard[i]) AmtCorrect++;
            }
            Console.WriteLine("Correct gusses:" + AmtCorrect);
        }
    }
}
