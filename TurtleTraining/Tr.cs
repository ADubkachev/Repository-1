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
      
        static void DL(int sizeDL)
        {
            Turtle.Angle = 0;
            Turtle.Speed = 8;
            Turtle.X = sizeDL;
            Turtle.Y = 200;

        } 
        static void WrR(int sizeR) {

            Turtle.Move(sizeR);
            Turtle.TurnRight();

            for (int a = 0; a < 3; a++)
            {
                Turtle.Move(sizeR/2);
                Turtle.TurnRight();
            }
        }


        static void WrT(int sizeT) {

            Turtle.Move(sizeT);
            Turtle.TurnLeft();

            Turtle.Move(sizeT/3);
            Turtle.Turn(180);

            Turtle.Move(sizeT/3*2);
        }

        static void WrO(int sizeO) {

            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(sizeO);
                Turtle.TurnRight();
            }

        }
        static void Main(string[] args)
        {
            DL(200);

            WrT(100);

            DL(250);

            WrO(60);

            DL(340);

            WrR(60);

            DL(410);

            WrT(60);


        }

    }
}
