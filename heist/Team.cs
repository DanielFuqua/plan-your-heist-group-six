using System;
using System.Collections.Generic;

namespace heist
{
    public class Team
    {
        private List<Member> _members = new List<Member>();

        public void AddToList(Member newMember)
        {
            _members.Add(newMember);
        }

        public void DisplayMembers()
        {
            foreach (Member teamMember in _members)
            {
                Console.WriteLine(teamMember);
            }

        }

        public int NumberOfMembers()
        {
          return _members.Count;
        }
        
        public int TotalSkillLevel()
        {
            int SkillLevel = 0;
            _members.ForEach(teamMember => SkillLevel += teamMember.Skill);
            return SkillLevel;
        }
    }
}