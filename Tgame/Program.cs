﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Tgame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(20, 20);


            int x = 200;
            int y = 200;

            Random rnd = new Random();
            Shapes.Move(eat, x, y);

            while (true) {


                if (Turtle.X >= x && Turtle.Y >= y && Turtle.X <= x + 20 && Turtle.Y <= y + 20)
                {

                    x = rnd.Next(0, GraphicsWindow.Width);
                    y = rnd.Next(0, GraphicsWindow.Height);

                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                } 

                Turtle.Move(10);
            }
        }

        private static void GraphicsWindow_KeyDown()
        {

            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 271;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 181;
            }

        }
    }
}
