namespace ThisIsTheMF
{
    public class Player
    {
        private string Name { get; set; } // Имя игрока
        private int AvailableStudents; // Сколько студентов имеется на данный момент в распоряжении
        public Player(string name)
        {
            Name = name;
            AvailableStudents = 4; /* Пока поставим Четыре доступных студента.
                                      По ходу игры это число может увеличиваться,
                                      либо уменьшаться, если со студентами что-то случится.*/
        }
    }
}