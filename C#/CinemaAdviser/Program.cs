using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Программа для подбора фильмов!");
            Console.WriteLine("Как  вас зовут?");
            String name = Console.ReadLine();
            String a = "комедия";
            String b = "драмма";
            String c = "триллер";
            String d = "боевик";

            String v; 


            Console.WriteLine(name+ ", какой жанр вам интересен, "+a+" , " +b+ " , " +c+ " или " +d+"?");

            String cin = Console.ReadLine();


                if (cin == a)
                {

                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                }
                else if (cin == b)
                {


                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("8");

                }  

                else if (cin == c)
                {

                Console.WriteLine(name + ", сколько вам лет?");
                String year = Console.ReadLine();

                int year32 = Int32.Parse(year);

                if (year32 >= 18)
                {

                    Console.WriteLine("9");
                    Console.WriteLine("10");
                    Console.WriteLine("11");
                    Console.WriteLine("12");

                }
                else {
                    Console.WriteLine("Ваш возраст не достаточен, для просмотра данных фильмов. \nПриходите, когда вам будет 18+");        
                     }

                }
                else if (cin == d)
                {

                Console.WriteLine(name + ", сколько вам лет?");
                String year = Console.ReadLine();

                int year32 = Int32.Parse(year);

                if (year32 >= 15)
                {
                    Console.WriteLine("13");
                    Console.WriteLine("14");
                    Console.WriteLine("15");
                    Console.WriteLine("16");

                }
                else
                {
                    Console.WriteLine("Ваш возраст не достаточен, для просмотра данных фильмов. \nПриходите, когда вам будет 15+");
                }
                

                }
            
            else { Console.WriteLine("Такого жанра нет");

            }

            Console.ReadLine();

        }

    }
}
