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

            Console.SetBufferSize(120, 30);

            //отрисовка рамочки
            //HorizontalLine upLine = new HorizontalLine(0, 119, 0, '*');
            //HorizontalLine downLine = new HorizontalLine(0, 119, 28, '*');
            //VerticalLine leftLine = new VerticalLine(0, 0, 28, '*');
            //VerticalLine rightLine = new VerticalLine(119, 0, 28, '*');
            //upLine.LineDraw();
            //downLine.LineDraw();
            //leftLine.LineDraw();
            //rightLine.LineDraw();

            Walls walls = new Walls(119, 28);
            walls.Draw();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.LineDraw();

            FoodCreator foodCreator = new FoodCreator(120, 30, '#');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                snake.Move();
                Thread.Sleep(200);
            }
        }
    }
}
