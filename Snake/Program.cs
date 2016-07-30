using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(125, 30);

            Walls walls = new Walls(100, 28);
            walls.Draw();

            // Отрисовка точек
            Point p = new Point(4,5,'+');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(100, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            int eatscore = 0;

            while (true)
            {
                if (walls.IsHit(snake)) //|| snake.IsHitTail())
                {
                    WriteGameOver();
                    break;
                }
                if (snake.Eat(food))
                {
                    eatscore += 10;
                    Point eatscores = new Point(100, 2, eatscore.ToString());
                    eatscores.Draw(eatscore.ToString());
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(70);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            WriteGameOver();
            Console.ReadLine();
        }

        static void WriteGameOver()
        {
            int xOffset = 35;
            int yOffset = 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText(new string ('-', 30), xOffset, yOffset++);
            WriteText("И Г Р А    З А В Е Р Ш Е Н А", xOffset + 1, yOffset++);
            WriteText(new string('-', 30), xOffset, yOffset++);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
