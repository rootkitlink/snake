using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public string eatscore;

        public Point()
        {

        }

        public Point(int x, int y, string eatscore)
        {
            this.x = x;
            this.y = y;
            this.eatscore = eatscore;
        }

        public Point (int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            if (direction == Direction.UP)
            {
                y = y - offset;
            }
            if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Draw(String eatscore)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write("Счет: " + eatscore + "$");
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool IsHit (Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
