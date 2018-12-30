using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class prac_work
    {
        static void Main(string[] args)
        {

            //1
            Console.WriteLine("ЗАДАЧА №1");
            Console.Write("Введите X : ");
            int x = int.Parse(Console.ReadLine());
            var y = (7 * (x * x)) - (3 * x) + 4;
            Console.WriteLine("y = " + y);
            Console.WriteLine("--------------------------------------------------");


            //2
            Console.WriteLine("ЗАДАЧА №2");
            Console.Write("Введите радиус :");
            int R = int.Parse(Console.ReadLine());

            var a = 2 * Math.PI * R;
            var S = Math.PI * R * R;
            Console.WriteLine("Длина: " + a);
            Console.WriteLine("Площадь: " + S);
            Console.WriteLine("--------------------------------------------------");


            //3
            Console.WriteLine("ЗАДАЧА №3");
            Console.Write("Введите растояние в сантиметрах: ");
            int cm = int.Parse(Console.ReadLine());
            int hundred = 100;
            int m = cm / hundred;
            Console.WriteLine("полное растояние в метрах: " + m);
            Console.WriteLine("--------------------------------------------------");


            //4
            Console.WriteLine("ЗАДАЧА №4");
            int day = 234;
            int seven = 7;
            int week = day / seven;
            Console.WriteLine("Дано 234 дней ");
            Console.WriteLine("полных недель  : " + week);
            Console.WriteLine("--------------------------------------------------");
            
            


            //5
            Console.WriteLine("ЗАДАЧА №5");
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            int ten = 10;
            int a1 = number / ten;
            int a2 = number % 10;
            int proiz = a2 * a1;
             int sum = a1 + a2;

            Console.WriteLine("Десятков " + a1);
            Console.WriteLine("Единицы " + a2);
            Console.WriteLine("Сумма двух цифр " + sum);
            Console.WriteLine("ПРОизведение двух цифр " + proiz);
            Console.WriteLine("--------------------------------------------------");



            //6
            Console.WriteLine("ЗАДАЧА №6");
            Console.Write("Введите четырехзначное число: ");
            int number_2 = int.Parse(Console.ReadLine());
            int sum_2 = 0;
            
            int tysiachi = number_2 / 1000;
            int desyatki = number_2 % hundred / ten;
            int sotni = number_2 % 1000 / hundred;
            int edinici = number_2 % 10;

            while (number_2 != 0)
            {
                sum_2 += number_2 % ten;
                number_2 /= ten;
            }

            int proiz_2 = tysiachi * sotni * desyatki * edinici;

            Console.WriteLine("Сумма цифр " + sum_2);
            Console.WriteLine("Произведение цифр " + proiz_2);
            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
           

            
        }
    }
}
