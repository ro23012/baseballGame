using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseballGame
{
    internal class Gamechar
    {
        protected string name;
        protected int speed;
        protected int power;

        public Gamechar(string name, int speed, int power)
        {
            this.name = name;
            this.speed = speed;
            this.power = power;
        }


        public void Show()
        {
            Console.WriteLine("選手名：{0}　球速：{1}　パワー；{3}",this.name,this.speed,this,power);
        }

        public void Throw()
        {


            //ストライク　ボール　アウト　の変数作成
            string [] strike = {"●", "●●", "●●●" };
            string [] boll = { "●", "●●", "●●●", "●●●●" };

            //乱数の作成
            Random ran = new Random();

            //カウントするやつ
            int countS = 0;
            int countB = 0;


            string select = Console.ReadLine();

            if (select == "T")
            {
                while (strike.Length > 3 || boll.Length > 4)
                {
                    int random = ran.Next(1, 5);
                    int exeSpeed = random * this.Speed / 100;
                    if (exeSpeed > 5)
                    {
                        countS = countS + 1;
                        Console.WriteLine(strike[countS]);

                    }
                    else if (exeSpeed < 5)
                    {
                        countB = countB + 1;
                        Console.WriteLine(boll[countB]);
                    }
                }

            }


        }


        public string Name
        {
            set { name = value; }
            get { return this.name; }
        }

        public int Speed
        {
            set { this.speed = value; }
            get { return this.speed; }
        }

        public int Power
        {
            set { this.power = value; }
            get { return this.power; }
        }




    }



}
