using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeLsit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();  //Read teh input and turn it into List

            while (true)
            {
                string command = Console.ReadLine(); //keep receiving commands

                if (command == "end")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                string[] receivedCommands = command.Split(' ');

                string newCommand = receivedCommands[0];

                if (newCommand == "Delete")
                {
                    int element = int.Parse(receivedCommands[1]);
                    numbers.RemoveAll(n => n == element);
                }
                else  // newCommand == "Insert"
                {
                    int element = int.Parse(receivedCommands[1]);
                    int idx = int.Parse(receivedCommands[2]);
                    numbers.Insert(idx, element);
                }                               
            }
        }
    }
}
