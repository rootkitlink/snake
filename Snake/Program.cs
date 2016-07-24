﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine l1 = new HorizontalLine(5, 12, 7, '@');
            VerticalLine l2 = new VerticalLine(13, 5, 15, '@');
            l1.LineDraw();
            l2.LineDraw();
            Console.ReadLine();
        }
    }
}
