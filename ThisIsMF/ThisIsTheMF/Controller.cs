using System;
using System.Text;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public static class Controller
    {
        private static void GameOver()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "MainMenu")
                    form.Close();
            }
        }
        
        public static int AdjustPlayerRep(int reputation)
        {
            if (reputation % 4 == 0);
            {
                Player.StudentsList[new Random().Next(0,3)].Stats[new Random().Next(0,3)]++;
                MessageBox.Show("Один из ваших помощников научился чему-то новому!","Прогресс!");
            }
            return reputation+1;
        }

        public static void DamagePlayer()
        {
            var lives = Player.Lives;
            if (lives == -3)
            {
                var finalMessage = new StringBuilder(
                    "Ну тут даже шутить не буду, тебя отчислили, бро.\n");
                switch (Player.Reputation)
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
                GameOver();
            }
        }
    }
}