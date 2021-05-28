using System.Collections.Generic;

namespace ThisIsTheMF
{
    public class Player
    {
        public string Name;
        public List<Student> StudentsList; // Сколько студентов имеется на данный момент в распоряжении
        public Player(string name)
        {
            Name = name;
            //StudentsList = recruitsLimit;
        }

        public void CreatePlayerTeam(List<Student> recruits)
        { 
            StudentsList = new List<Student>(recruits);
        }
    }
}