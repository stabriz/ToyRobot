using ToyRobot.Interface;

namespace ToyRobot
{
    public class Table : ITable
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Table(int lenght, int widht)
        {
            Length = widht;
            Width = lenght;
        }

        public bool IsValidPosition(Position position)
        {
            return position.X >=0 && position.X <=Width && position.Y >=0 && position.Y <=Width;
        }
    }

    
}
