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
        public Tuple<int,string> requiredStat; //Значение статы, Название статы
        //Крч, идея такова:
        //У каждой миссии есть стата, которую нужно удовлетворить
        //( Стата студента не меньше требуемой )
        //Проверяем это, в зависимости от результата происходит что-либо
        //Фишки статов расписал в Map.cs
        
        public Situation()
        {
            InitializeComponent();
        }
    }
}
