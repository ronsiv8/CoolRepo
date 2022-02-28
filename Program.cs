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
        }
    }
}
