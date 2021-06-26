using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public static class Player
    {
        public static int Lives = Difficulty.Level;
        public static int Reputation;
        public static string Name;
        public static List<Student> StudentsList; // Студенты в распоряжении

        
        public static Student GetStudent(string name)
        {
            foreach (var student in StudentsList)
            {
                if (name == student.Name)
                    return student;
            }
            return null;
        }

        public static void TakeDamage()
        {
            Controller.DamagePlayer();
        }

        public static void TakeReputation()
        {
            Reputation = Controller.AdjustPlayerRep(Reputation);
        }
    }
}