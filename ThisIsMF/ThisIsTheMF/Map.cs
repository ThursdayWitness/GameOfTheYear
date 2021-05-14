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
        private string statusEvent = "noone"; // вызов события на карте
        private readonly Random _random = new Random();

        public Map()
        {
            InitializeComponent();


            //matfuck
            pictureMap.Controls.Add(dialogEvent);
            dialogEvent.Location = new Point(418, 146);
            dialogEvent.BackColor = Color.Transparent;
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

        private List<string> CreateEvent(List<string> status)
        { 
            List<string> listEvents = (new string[] { "matfuck", "socgum", "sok", "ipip" }).ToList();
            IEnumerable<string> randomEvent = listEvents.OrderBy(x => _random.Next()).Take(4);
            status = randomEvent.Select(p => status).ToList(); 
            return status;
            //генерируются события
            // пока не получается :9
        }

        private void dialogEvent_Click(object sender, EventArgs e)
        {
            CreateEvent(statusEvent);
            switch (statusEvent)
            {
                case "matfuck":
                    pictureMap.Controls.Add(dialogEvent);
                    dialogEvent.Location = new Point(418, 146);
                    dialogEvent.BackColor = Color.Transparent;
                    break;
                case "socgum":
                    pictureMap.Controls.Add(dialogEvent);
                    dialogEvent.Location = new Point(564, 92);
                    dialogEvent.BackColor = Color.Transparent;
                    break;
                case "sok":
                    pictureMap.Controls.Add(dialogEvent);
                    dialogEvent.Location = new Point(382, 154);
                    dialogEvent.BackColor = Color.Transparent;
                    break;
                case "ipip":
                    pictureMap.Controls.Add(dialogEvent);
                    dialogEvent.Location = new Point(547, 500);
                    dialogEvent.BackColor = Color.Transparent;
                    break;
                default:
                    break;
            }
        }
    }
}
