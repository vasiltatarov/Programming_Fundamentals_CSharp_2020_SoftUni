﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_01
{
    class Program
    {
        /*
Write a program that keeps information about companies and their employees. You will be receiving a company name and an employee's id,
until you receive the command "End" command. Add each employee to the given company. Keep in mind that a company cannot have two
employees with the same id. When you finish reading the data, order the companies by the name in ascending order. 
Print the company name and each employee's id in the following format:
Input / Constraints :
Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
SoftUni -> AA12345
SoftUni -> BB12345
Microsoft -> CC12345
HP -> BB12345
End
Output :
HP
-- BB12345
Microsoft
-- CC12345
SoftUni
-- AA12345
-- BB12345
         */
        static void Main()
        {
            var companys = new SortedDictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] line = command.Split(" -> ");

                string companyName = line[0];
                string employeeId = line[1];

                if (companys.ContainsKey(companyName) && !companys[companyName].Contains(employeeId))
                {
                    companys[companyName].Add(employeeId);
                }
                else if (!companys.ContainsKey(companyName))
                {
                    companys.Add(companyName, new List<string>());
                    companys[companyName].Add(employeeId);
                }

                command = Console.ReadLine();
            }

            foreach (var company in companys)
            {
                Console.WriteLine(company.Key);

                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
