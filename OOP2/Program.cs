using System;

namespace OOP2
{
    class TV
    {
        public int PEREKLTV = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Чтобы переключить канал нажмите: '+' либо '-' ");

            TV Channel = new TV();
            bool tv = true;


            while (tv)
            {
                string Switch = Console.ReadLine();
                if (Switch == "+")
                {
                    Channel.PEREKLTV++;
                }

                else if (Channel.PEREKLTV == 100)
                {
                    Channel.PEREKLTV = 0;
                }
                else if (Switch == "-" && Channel.PEREKLTV == 0)
                {
                    Channel.PEREKLTV = 100;
                }
                else if (Switch == "-")
                {
                    Channel.PEREKLTV--;
                }
                Console.WriteLine("Вы переключили на " + Channel.PEREKLTV + " канал");

            }



            Console.ReadLine();
        }
    }
}
