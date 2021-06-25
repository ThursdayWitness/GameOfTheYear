using System;
using System.Collections.Generic;

namespace ThisIsTheMF
{
    public class Student
    {
        public readonly string Name; //Имена пишем с жизни
        private readonly Random _random = new();
        private static readonly List<string> Names = new()
        {
            "Кирилл Кориков", "Никита Бродель", "Иван Тян",
            "Илья-семпай", "Дима Милютин", "Евгений Сапов",
            "Наталья Хабибулаева", "Даниил Матвеев", "Влад Нетёсов",
            "Александр Кормич", "Никита Гуничев", "Максим Лебедько",
            "Александр Юдин", "Ян Мухаметов", "Никита Попов", 
            "Денис Топычканов", "Злата Перминова", "Илья Соболев"
            // Список, ясен пень, ещё будет дополняться
        };

        public static readonly List<string> StudentNames = Names;

        public readonly List<int> Stats = new(); 
        //TODO?:
        //В зависимости от имени, к тем или иным статам
        //будут дополнительно добавляться/отниматься значения

        public Student() //Параметры студентов.
        {
            //Параметры генерируются случайным образом в диапазоне от 1 до 9.
            try
            {
                Name = StudentNames[_random.Next(0, Names.Count - 1)];
                Stats.Add(_random.Next(1, 9)); //Ум
                Stats.Add(_random.Next(1, 9));//Красноречие
                Stats.Add(_random.Next(1, 9));//Дерзость
                Stats.Add(_random.Next(1, 9));//Сочувствие
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }

        }
    }
}