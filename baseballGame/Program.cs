using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("パワプロさん");

            //選手選択
            Console.WriteLine("選手を選択してください");
            Console.WriteLine("A,　大谷さん");
            Console.WriteLine("B,　佐々木さん");
            Console.WriteLine("C, 及川さん");




            string select = Console.ReadLine();
            if(select == "A")
            {
                Gamechar otani = new Gamechar("大谷", 170, 100);
                otani.Show();
                Console.WriteLine("T ボールを投げる");
                otani.Throw();
                
            }
            else if (select == "B")
            {
                Gamechar sasaki = new Gamechar("佐々木", 160, 50);
                sasaki.Show();
            }
            else if (select == "C")
            {
                Gamechar oikawa = new Gamechar("及川", 50, 15);
                oikawa.Show();
            }
            else
            {
                
            }















        }
    }
}
