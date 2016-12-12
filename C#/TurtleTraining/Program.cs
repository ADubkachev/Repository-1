using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void WrR(int sizeR) {

            Turtle.Move(sizeR);
            Turtle.TurnRight();

            Turtle.Move(sizeR/2);
            Turtle.TurnRight();

            Turtle.Move(sizeR/2);
            Turtle.TurnRight();

            Turtle.Move(sizeR / 2);


        }


        static void WrT(int sizeT) {

            Turtle.Move(sizeT);
            Turtle.TurnLeft();

            Turtle.Move(sizeT/3);
            Turtle.Turn(180);

            Turtle.Move(sizeT/3*2);

        }

        static void WrO(int sizeO) {

            Turtle.Angle = 0;

            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(sizeO);
                Turtle.TurnRight();
            }

        }
        static void Main(string[] args)
        {
            Turtle.Angle = 0;
            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;

            WrT(100);


            Turtle.Angle = 0;
            Turtle.Speed = 8;
            Turtle.X = 250;
            Turtle.Y = 200;


            WrO(60);


            Turtle.Angle = 0;
            Turtle.Speed = 8;
            Turtle.X = 340;
            Turtle.Y = 200;



            WrR(60);

            Turtle.Angle = 0;
            Turtle.Speed = 8;
            Turtle.X = 410;
            Turtle.Y = 200;

            WrT(60);










        }
    }
}
