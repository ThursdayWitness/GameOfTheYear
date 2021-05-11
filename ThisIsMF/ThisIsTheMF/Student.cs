using System;
using System.Collections.Generic;

namespace ThisIsTheMF
{
    public class Student
    {
        public readonly string Name; //Имена пишем с жизни
        private readonly Random _random = new Random();
        private List<string> studentNames = new()
        {
            "Кирилл", "Никита", "Иван", "Алексей" 
            // Список, ясен пень, ещё будет дополняться
        };

        public List<int> Stats = new(); 
        //В зависимости от имени, к тем или иным статам
        //будут дополнительно добавляться/отниматься значения

        private string GenerateName()
        {
            var name = studentNames[_random.Next(0, studentNames.Count - 1)];
            studentNames.Remove(name);
            return name;
        }
        public Student() // Параметры студентов.
        {
            //Параметры генерируются случайным образом,
            //но общая сумма их стат не может превышать заданное число,
            //определяемое сложностью игры
            //пока что числа просто генерируются случайно в диапазоне 1-9
            Name = GenerateName();
            Stats.Add(_random.Next(1,9));//Ум
            Stats.Add(_random.Next(1,9));//Красноречие
            Stats.Add(_random.Next(1,9));//Смекалка
            Stats.Add(_random.Next(1,9));//Дерзость
            Stats.Add(_random.Next(1,9));//Сочувствие
            //Надо бы как-то через код подписать эти статы
        }
       
    }
}