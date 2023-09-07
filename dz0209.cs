using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dz0209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("  Труд");
            Console.WriteLine("     Май");
            Console.ReadKey();

            ///Задание 2 

            Console.WriteLine("Задание 2");
            Console.WriteLine("Необходимо ввести 2 числа");
            double chislo1, chislo2;
            while (true)
            {
                try
                {
                    chislo1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                    chislo2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели нечисловое значние. Попробуйте еще раз!");
                }
            }


            Console.WriteLine("Введенные числа поменялись местами. Ответ:");
            double newchislo1 = chislo1;
            double newchislo2 = chislo2;
            Console.WriteLine("{1}, {0}", newchislo1, newchislo2);

            ///Задание 3 
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите радиус окружности");
            while (true)
            {
                try
                {
                    double radius = double.Parse(Console.ReadLine());
                    double len = 2 * radius * Math.PI;
                    double area = radius * radius * Math.PI;
                    Console.WriteLine("Длина окружности: {0}, площадь окружности: {1} ", len, area);

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Попробуйте еще раз!");
                }
            }
            /// Задание 4 
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите значнеие x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cos {0} = {1}", x, Math.Cos(x));
            /// Задание 5 
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите коэффициенты");
            while (true)
            {
                try
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    double D = b * b - 4 * a * c;
                    
                    
                   
                    if (D < 0.0)
                    {
                        Console.WriteLine("Нет решения");

                    }
                    else if (D == 0.0)

                    {
                        double sqrtd = Math.Sqrt(D);
                        double x1 = (-b / (2 * a));
                        Console.WriteLine($"Корнем уравнения является {x1}");
                    }
                    else
                    {


                        double sqrtd = Math.Sqrt(D);
                        double x1 = ((-b + sqrtd) / (2 * a));
                        double x2 = ((-b - sqrtd) / (2 * a));

                        Console.WriteLine($"Корнями уравннеия являются {x1}, {x2}");

                    }
                    break;
                }
                

                catch (FormatException)

                {

                    Console.WriteLine("Вы ввели некорректные данные. Попробуйте еще раз!");
                }

            }



                ///Задание 6 
                Console.WriteLine("Задание 6");
                Console.WriteLine("Введите значения для переменных a, b, c");
                while (true)
                {
                    try
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine($"a) Ответ: a = {b}, b = {c}, c = {a}");
                        Console.WriteLine($"b) Отыет: а = {c}, b = {a}, c = {b}");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                }
            ///Задание 7

            Console.WriteLine("Задание 7 ");
            Random ch = new Random();
            int ch1 = ch.Next();
            int ch2 = ch.Next();
            int ch3 = ch.Next();
            int ch4 = ch.Next();
            Console.WriteLine("\n {0} \n {1} \n {2} \n {3}", ch1, ch2, ch3, ch4);

            /// Задание 8 
            Console.WriteLine("Задание 8");
            string num =  Console.ReadLine();
            int dlina = num.Length;
            if (dlina == 3 ) 
            {
                Console.WriteLine("{0},{1},{2} ", num[2], num[0], num[1]);
            }
            else
            {
                Console.WriteLine("Ошибка!");
             
            
                
            }
            ///Задание 9 
            Console.WriteLine("Введите стоимость 1кг конфет, печенья и яблок");
            while (true)
            {
                try
                {
                    double candies = double.Parse(Console.ReadLine());
                    double cookies = double.Parse(Console.ReadLine());
                    double apples = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите вес (кг) конфет, печенья, яблок");

                    double cand = double.Parse(Console.ReadLine());
                    double cook = double.Parse(Console.ReadLine());
                    double app = double.Parse(Console.ReadLine());
                    double summ = candies * cand + cookies * cook + apples * app;
                    Console.WriteLine($"Общая стоимость: {summ}");
                    break;

                }
                catch (FormatException) 
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            }

            
            
               
            

             









                Console.ReadKey();






            }
        }
    } 
