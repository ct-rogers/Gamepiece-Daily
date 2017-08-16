using System;

namespace gamePiece_dotnet
{
    class Program
    {
        public class GamePiece
        {
            public int PositionX { get; set; } = 0;
            public int PositionY { get; set; } = 0;
            public bool Frozen { get; set; } = false;
            public string Name { get; set; }
            public string Color { get; set; }
            Random random = new Random();

            public GamePiece(string name, string color)
            {
                Name = name;
                Color = color;
            }

            public Boolean freeze()
            {
                Frozen = true;
                return Frozen;
            }

            public Boolean unFreeze()
            {
                Frozen = false;
                return Frozen;
            }
            
            public int Move()
            {
                if (Frozen == false)
                {
                    PositionX = random.Next(0,100);
                    PositionY = random.Next(0,500);
                    return PositionX;
                }
                else
                {
                    return PositionX;
                }
            }
            public override string ToString()
            {
                if (Frozen == false)
                {
                   return $"{Name} {Color} has moved to X:{PositionX}, Y:{PositionY}."; 
                }
                else
                {
                   return $"{Name} {Color} is Frozen and Can't Move.";
                }
            }
        }
        static void Main(string[] args)
        {
            var piece1 = new GamePiece("Big", "Red");

            piece1.Move();
            Console.WriteLine(piece1);

            piece1.freeze();
            Console.WriteLine(piece1);

            piece1.unFreeze();

            piece1.Move();
            Console.Write(piece1);

            piece1.freeze();
            Console.WriteLine(piece1);

            piece1.unFreeze();

            piece1.Move();
            Console.Write(piece1);
        }
    }
}