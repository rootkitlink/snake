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
            //point p1 = new point(1, 3, '*');
            //p1.draw();
            
            //point p2 = new point(4, 5, '#');
            //p2.draw();

            //horizontalline l1 = new horizontalline(5, 12, 7, '*');
            //verticalline l2 = new verticalline(13, 5, 15, '*');
            //l1.linedraw();
            //l2.linedraw();

            Console.SetBufferSize(120, 30);

            //отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 119, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, 119, 28, '*');
            VerticalLine leftLine = new VerticalLine(0, 0, 28, '*');
            VerticalLine rightLine = new VerticalLine(119, 0, 28, '*');
            upLine.LineDraw();
            downLine.LineDraw();
            leftLine.LineDraw();
            rightLine.LineDraw();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.LineDraw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                snake.Move();
                Thread.Sleep(200);
            }

            Console.ReadLine();

        }
    }
}
