using System.Collections.Generic;

namespace ThisIsTheMF
{
    public class Student
    {
        private string Name; //Имена пишем с жизни

        private Dictionary<int, string> Stats = new Dictionary<int, string>(5);

        public Student(string name, string stats) // Параметры студентов
        {
            //Параметры генерируются случайным образом,
            //но общая сумма их стат не может превышать заданное число.
            Name = name;
            Stats.Add(stats[0],"Ум");
            Stats.Add(stats[1],"Красноречие");
            Stats.Add(stats[2],"Смекалка");
            Stats.Add(stats[3],"Дерзость");
            Stats.Add(stats[4],"Сочувствие");
        }
       
    }
}