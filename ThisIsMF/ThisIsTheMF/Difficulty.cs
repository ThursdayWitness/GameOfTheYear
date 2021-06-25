using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public static class Difficulty
    {
        public static int Level { get; private set; }
        private static readonly string[] Levels =
        {"Сложно", "Ничё так", "Легко"};
        
        public static void SetLevel(string text)
        {
            for (var i = 0; i < Levels.Length; i++)
            {
                if (Levels[i] == text) Level = i;
            }
        }
    }
}