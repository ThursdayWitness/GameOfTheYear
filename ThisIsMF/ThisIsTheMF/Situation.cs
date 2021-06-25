using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class Situation : Form
    {
        private static List<string> _locations = new()
        {
            "Матфаке", "СоцГуме", "ФЭИ", "СОКе"
        };

        public static string Location = _locations[new Random().Next(0, _locations.Count - 1)]; 
        private Tuple<int, int> requiredStat { get; } //Значение статы, Код статы
        //Коды стат:
        //0 - инта, 1 - красноречие, 2 - дерзость, 3 - сочувствие
        //Крч, идея такова:
        //У каждой миссии есть стата, которую нужно удовлетворить
        //( Стата студента не меньше требуемой )
        //Проверяем это, в зависимости от результата происходит что-либо
        //Фишки статов расписал в Map.cs

        public string Description;
        private static readonly Dictionary<int, string> MissionDescriptions = new()
        {
            //Описания - своего рода подсказки к требуемой стате
            [0] = $"Кто-нибудь понял последнюю тему и может её пояснить? Я жду в {Location}.",
            [1] = $"Не могу сдать лабу, преподаватель отказывается меня слушать! Есть кто в {Location}?",
            [2] = $"Дед снова за своё, так мы никогда не получим баллы! Нужно подкрепление в {Location}."
        };

        public Situation()
        {
            InitializeComponent();
            requiredStat = new Tuple<int, int>(new Random().Next(0, 8), new Random().Next(0,2));
            Description = $"Хэй хэй, {Player.Name}! Нужна помощь! "+MissionDescriptions[requiredStat.Item2];
        }
        
        
    }
}
