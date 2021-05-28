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
        private static List<string> statusEvent = new() { "matfuck", "socgum", "sok", "ipip" }; // вызов события на карте
        private static readonly Random _random = new();
        private int timeLeft;
        //private readonly studentsList = 

        public Map()
        {
            InitializeComponent();
            

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
            var index = _random.Next(statusEvent.Count);
            var randomItem = statusEvent[index];
            timerStartSession.Start();
            if (timerStartSession.Enabled)
            {
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
        }

        private static void CreateEvents()
        {
            var index = _random.Next(statusEvent.Count);
            var randomItem = statusEvent[index];
            switch (randomItem)
            {
                case "matfuck":
                    var situationMatfuck = new Situation();
                    situationMatfuck.ShowDialog();
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
    }
}
