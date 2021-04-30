using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class RecruitsWindow : Form
    {
        public RecruitsWindow()
        {
            //Меню выбора рекрутируемых студентов
            InitializeComponent();
            var student1 = new Student();
            Recruit.Text = student1.Name;
            knowledgeStat.Text = student1.Stats[0].ToString();
            speakingStat.Text = student1.Stats[1].ToString();
            proficiencyStat.Text = student1.Stats[2].ToString();
            gutsStat.Text = student1.Stats[3].ToString();
            kindnessStat.Text = student1.Stats[4].ToString();
            
            //TODO:
            // Вот это говно выше надо бы зарефакторить
            //И сделать генерацию сразу нескольких студентов, но тут проблема с созданием новых
            //элементов в окне, хотя не, так-то не проблема, только что понял, как это сделать.
        }
    }
}