﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_01
{
    class Program
    {
        /*
Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.
The program receives 2 commands:	
"register {username} {licensePlateNumber}":
The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username,
the system should print: "ERROR: already registered with plate number {licensePlateNumber}"
If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
 "{username} registered {licensePlateNumber} successfully"
"unregister {username}":
If the user is not present in the database, the system should print: "ERROR: user {username} not found"
If the aforementioned check passes successfully, the system should print:
"{username} unregistered successfully"
After you execute all of the commands, print all the currently registered users and their license plates in the format: 
"{username} => {licensePlateNumber}"
Input
First line: n, Next n lines: commands in one of the two possible formats:
Register: "register {username} {licensePlateNumber}"
Unregister: "unregister {username}"
The input will always be valid and you do not need to check it explicitly.
4
register Jony AA4132BB
register Jony AA4132BB
register Linda AA9999BB
unregister Jony
         */
        static void Main()
        {
            var licensePlateNumbers = new Dictionary<string, string>();

            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                string[] registerInfo = Console.ReadLine().Split(" ");

                if (registerInfo[0] == "register")
                {
                    string username = registerInfo[1];
                    string licensePlateNumber = registerInfo[2];

                    if (licensePlateNumbers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumbers[username]}");
                    }
                    else
                    {
                        licensePlateNumbers.Add(username, licensePlateNumber);

                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (registerInfo[0] == "unregister")
                {
                    string username = registerInfo[1];

                    if (licensePlateNumbers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");

                        licensePlateNumbers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var licenseNum in licensePlateNumbers)
            {
                Console.WriteLine($"{licenseNum.Key} => {licenseNum.Value}");
            }
        }
    }
}
