﻿using System;
using System.Collections.Generic;

namespace Problem_01
{
    class Program
    {
        //You will be given a sequence of strings, each on a new line.Every odd line on the console is representing a resource(e.g. Gold,
        //Silver, Copper, and so on) and every even - quantity.Your task is to collect the resources and print them each on a new line.
        //Print the resources and their quantities in the following format: {resource} –> {quantity}

        static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }

                command = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
