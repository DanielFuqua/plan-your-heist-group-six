using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();
            Console.WriteLine("What is the banks difficulty level? (should be an integer)");
            int bankDifficultyLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Create a Team Member.");
            Team heistTeam = new Team();

            while (true)
            {

            // Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Enter team member's name");

            Console.Write("Name> ");
            string userName = Console.ReadLine();
            if(String.IsNullOrEmpty(userName))
            {
                break;
            }

            // Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.WriteLine($"Welcome to the team, {userName}! What's your skill level?");

            Console.Write("Skill> ");
            int userSkill = int.Parse(Console.ReadLine());

            // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            Console.Write("Courage> ");
            double userCourage = double.Parse(Console.ReadLine());

            // Instantiate a member object
            Member newMember = new Member()
            {
                Name = userName,
                Skill = userSkill,
                Courage = userCourage,

            };

            Console.WriteLine($"New member added to the team: {newMember}");

            heistTeam.AddToList(newMember);
            }

            Console.WriteLine($"The crew has {heistTeam.NumberOfMembers()} members and here they are:");
            heistTeam.DisplayMembers();

            

            Console.WriteLine("How many trial runs would you like to run?");
            int NumberOfTrialRuns = int.Parse(Console.ReadLine());
            int successes = 0;
            int failures = 0;

            for (int i = 0; i < NumberOfTrialRuns; i++)
            {
                int luckNumber = new Random ().Next (-10, 11);
                int finalDifficultyLevel = bankDifficultyLevel + luckNumber;
                Console.WriteLine($"Team's combined skill level is {heistTeam.TotalSkillLevel()}");
                Console.WriteLine($"The bank's difficulty level is {finalDifficultyLevel}");

                if (heistTeam.TotalSkillLevel() >= finalDifficultyLevel)
                {
                    Console.WriteLine("Bank heist was a success!");
                    successes++;
                } 
                else 
                {
                    Console.WriteLine("FAILURE... Heist team not skilled enough...");
                    failures++;
                }
            Console.WriteLine($"Successful heists: {successes}");
            Console.WriteLine($"Failed heists: {failures}");
            }
        }
    };
};
