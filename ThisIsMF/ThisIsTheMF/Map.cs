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
    public partial class Map : Form
    {
        private static readonly List<string> StatusEvent = new() { "matfuck", "socgum", "sok", "ipip" }; // вызов события на карте
        private static readonly Random Random = new();
        private int _timeLeft;

        public Map()
        {
            InitializeComponent();
            CenterToScreen(); //TODO: fullscreen mode
            timerEvent.Start();

            foreach (var i in Player.StudentsList)
            {
                panelStudents.Controls.Add(new Label
                {
                    Name = "UKDS",
                    Location = new Point(144, 0),
                    Text = "| У | К | Д | С |"
                });
                
                panelStudents.Controls.Add(new Label // Имя студента
                {
                    //Name = $"student{panelStudents.Controls.Count}", 
                    Location = new Point(10,16*(panelStudents.Controls.Count+1) + 16),
                    Text = i.Name,
                });

                var studentStats = "| ";
                foreach (var j in i.Stats) //Присваиваем созданной studentStats статы студента в виде текста
                { 
                    studentStats += j+" | ";
                }
                
                panelStudents.Controls.Add(new Label
                {
                    Name = $"student{panelStudents.Controls.Count/2}Stats",  
                    Location = new Point(144,16*(panelStudents.Controls.Count+1)),
                    Text = studentStats,// Вертикальная позиция зависит от кол-ва элементов на панели студентов,
                                        // плюс один, чтобы не подыхать при нуле элементов
                });
            }
            
            panelStudents.Controls.Add(new Label
            {
                Name = "statsExplanations",
                Text = "Ум - способность студента справиться с заданиями по теме предмета.\n" +
                       "Красноречие - шанс избежать негативных последствий при провале.\n" +
                       "Дерзость - \n" +
                       "Сочувствие - помощник может добавить половину соответствующей \n" +
                       "характеристики в соответствии с требованиями миссии",
                AutoSize = true,
                Location = new Point(0,panelStudents.Bottom)
                //Понятия не имею, как поставить её нормально
            });
            
            timerStartSession.Enabled = true;
            //matfuck
            //pictureMap.Controls.Add(dialogEvent);
            //dialogEvent.Location = new Point(418, 146);
            //dialogEvent.BackColor = Color.Transparent;
            //socgum
            //pictureMap.Controls.Add(dialogEvent);
            //dialogEvent.Location = new Point(564, 92);
            //dialogEvent.BackColor = Color.Transparent;
            //sok
            //pictureMap.Controls.Add(dialogEvent);
            //dialogEvent.Location = new Point(382, 154);
            //dialogEvent.BackColor = Color.Transparent;
            //ipip
            //pictureMap.Controls.Add(dialogEvent);
            //dialogEvent.Location = new Point(547, 500);
            //dialogEvent.BackColor = Color.Transparent;
        }

        private void CreateEvent(int x, int y)
        {
            pictureMap.Controls.Add(dialogEvent);
            dialogEvent.Location = new Point(x, y);
            dialogEvent.BackColor = Color.Transparent;
        }

        private void dialogEvent_Click(object sender, EventArgs e)
        {
            timerStartSession.Enabled = true;
            var index = Random.Next(StatusEvent.Count);
            var randomItem = StatusEvent[index];
            timerStartSession.Start();
            if (!timerStartSession.Enabled) return;
            switch (randomItem)
            {
                case "matfuck":
                    CreateEvent(418, 146);
                    CreateEvents();
                    CreateEventAsync();
                    break;
                case "socgum":
                    CreateEvent(564, 92);
                    CreateEvents();
                    CreateEventAsync();
                    break;
                case "sok":
                    CreateEvent(382, 154);
                    CreateEvents();
                    CreateEventAsync();
                    break;
                case "ipip":
                    CreateEvent(547, 500);
                    CreateEvents();
                    CreateEventAsync();
                    break;
            }
        }

        private static void CreateEvents()
        {
            var index = Random.Next(StatusEvent.Count);
            var randomItem = StatusEvent[index];
            switch (randomItem)
            {
                case "matfuck":
                    var situationMatfuck = new Situation();
                    situationMatfuck.ShowDialog(); // Возможно есть смысл здесь и далее заменить это на Show(),
                                                   // если будет необходимость смотреть кликабельную инфу с Map.
                    break;
                case "socgum":
                    var situationSocgum = new Situation();
                    situationSocgum.ShowDialog();
                    break;
                case "sok":
                    var situationSok = new Situation();
                    situationSok.ShowDialog();
                    break;
                case "ipip":
                    var situationIpip = new Situation();
                    situationIpip.ShowDialog();
                    break;
            }
        }

        private static async void CreateEventAsync()
        {
            await Task.Delay(10000);
        }

        string text = "Ивашко заебал Ивашко заебал           Ивашко заебал           Ивашко сайпал";
        private void timerEvent_Tick(object sender, EventArgs e)
        {
            text = text.Substring(3) + text[0];
            textBox1.Text = text;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            pictureMap.Controls.Add(dialogEvent);
            dialogEvent.Location = new Point(418, 146);
            dialogEvent.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible == true)
                flowLayoutPanel1.Visible = false;
            else
                flowLayoutPanel1.Visible = true;
        }
    }
}
