using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public static class Difficulty
    {
        public static int Level { get; private set; }
        private static readonly Dictionary<int, string> Levels = new()
        {
            [1] = "Легко",
            [2] = "Ничё так",
            [3] = "Сложно"
        };
        
        public static void SetLevel(string text)
        {
            foreach (var (key, value) in Levels)
            {
                if (value == text) Level = key;
            }
            //Level = Levels.Where(t => t.Key == text).Take(1).Select(t => t.Value);
            //Это было бы потрясно сделать с помощью LINQ, но пока не могу это сделать.
        }
        
    }
}