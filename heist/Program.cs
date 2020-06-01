using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();
            Console.WriteLine("Create a Team Member.");
            // Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Enter team member's name");

            Console.Write("Name> ");
            string userName = Console.ReadLine();

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
                Courage = userCourage
            };

            Console.WriteLine($"Name: {newMember.Name} Skill: {newMember.Skill} Courage :{newMember.Courage}");

        }
    }
}
