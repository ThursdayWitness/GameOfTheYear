namespace ThisIsTheMF
{
    public class Player
    {
        public string Name { get; set; } // Имя игрока
        public int AvailableStudents; // Сколько студентов имеется на данный момент в распоряжении
        public Player(string name, int recruitsLimit)
        {
            Name = name;
            AvailableStudents = recruitsLimit; /* Пока поставим Четыре доступных студента.
                                      По ходу игры это число может увеличиваться,
                                      либо уменьшаться, если со студентами что-то случится.*/
        }
        
        public int GetRecruitsLimit()
        {
            return AvailableStudents;
        }
    }
}