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

        private void CreateEvent()
        {
            //генерируются события
        }

        private void dialogEvent_Click(object sender, EventArgs e)
        {
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
