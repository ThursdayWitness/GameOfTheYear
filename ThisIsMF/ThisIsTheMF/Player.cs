using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public static class Player
    {
        public static int Lives = Difficulty.Level;
        private static int _reputation;
        public static string Name;
        public static List<Student> StudentsList; // Студенты в распоряжении

        
        public static Student GetStudent(string name)
        {
            foreach (var student in StudentsList)
            {
                if (name == student.Name)
                    return student;
            }
            return null;
        }

        public static void TakeDamage()
        {
            Lives--;
            if (Lives == -3)
            {
                var finalMessage = new StringBuilder(
                    "Ну тут даже шутить не буду, тебя отчислили, бро.\n");
                switch (_reputation)
                {
                    case > 16:
                        finalMessage.Append("Ты в числе легендарных студентов ТюмГУ.\n" +
                                            "Преподам снятся кошмары о тебе.\n" +
                                            "Студенты скидываются на статуэтку тебя.\n" +
                                            "А ещё на корпоративную почту от ТюмГУ ( её пока не вырубили )\n" +
                                            "пришло письмо от Рокфеллеров. Их впечатлили твои таланты в менеджменте персонала.");
                        break;
                    case >= 12:
                        finalMessage.Append("В ВУЗе ходят слухи о тебе.\n" +
                                            "Некоторые даже готовы платно обращаться за твоей помощью несмотря на отчисление!\n" +
                                            "Возможно имеет смысл развиваться в этом направлении?");
                        break;
                    case >= 8:
                        finalMessage.Append("Но есть и плюсы: однокурсники сделали игру в твою честь.\nУвековечили!");
                        break;
                    case >= 4:
                        finalMessage.Append("Тебе удалось помочь паре товарищей.\nЭтого точно не забудут.");
                        break;
                    case >= 0:
                        finalMessage.Append("Твоих стараний было недостаточно.\nСтоит пересмотреть свою стратегию.");
                        break;
                }
                MessageBox.Show(finalMessage.ToString(), "Гейм овер, хрен ли");
                MainMenu.GameOver();
            }
        }

        public static void TakeReputation()
        {
            _reputation++;
        }
    }
}