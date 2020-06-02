using System;


namespace heist
{
    public class Member
    {
        public string Name { get; set; }

        public int Skill { get; set; }

        public double Courage { get; set; }

        public override string ToString()
        {
             return $"Name: {Name}, Skill: {Skill}, Courage: {Courage}";
        }


    }


}
