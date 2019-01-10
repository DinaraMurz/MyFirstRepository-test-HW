using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson
{
    class Program
    {
        static double FuncFronFirstTask(int x){
            int seven = 7, four = 4, three = 3,sqr = 2;

            var y = seven * Math.Pow(x,sqr) - (three * x) + four;
            return y;
        }

        static void Main(string[] args)
        {

            //Console.WriteLine("Задание 1");
            //Console.WriteLine("Введите чисдо для формулы y = 7x^2 - 3x + 4 :");

            //var x = Convert.ToInt32(Console.ReadLine());
            //var y = FuncFronFirstTask(x);

            //Console.WriteLine("Итог y:" + y);
            //Console.ReadLine();


            //Console.WriteLine("Задание 2");
            //Console.WriteLine("Введите радиус окружности для нахождения длинны и площади окружности: ");

            //var Radius = Convert.ToInt32(Console.ReadLine());
            //var C = Math.PI * 2 * Radius;
            //var Square = Math.PI * Math.Sqrt(Radius);

            //Console.WriteLine("Длинна окружности: " + C);
            //Console.WriteLine("Площадь круга: " + Square);
            //Console.ReadLine();


            //Console.WriteLine("Задание 3");
            //Console.WriteLine("Введите растояние в сантиметрах для получения числа в полных петрах: ");

            //var distanceInCm = Convert.ToInt32(Console.ReadLine());
            //int hundred = 100;
            //int distanceInMeters = distanceInCm / hundred;

            //Console.WriteLine("Число в полных петрах: " +  distanceInMeters);
            //Console.ReadLine();


            //Console.WriteLine("Задание 4");
            //int pastTime = 234;
            //int daysInOneWeek = 7;
            //int weeksInTotal = pastTime / daysInOneWeek;

            //Console.WriteLine("Прошло " + weeksInTotal + " c " + pastTime + " дней");
            //Console.ReadLine();

            //Console.WriteLine("Задание 5");
            //Console.WriteLine("Введите двухзначное число: ");


            ////string FinalResult = "sum=" + sum + ";\n umnozhenie=..";
            ////Console.WriteLine(FinalResult);

            //int twoВigitТumber = Convert.ToInt32(Console.ReadLine());

            //int ten = 10;

            //int dozenOfTwoВigitТumber = twoВigitТumber / ten;
            //int singleOgtwoВigitТumber = twoВigitТumber - dozenOfTwoВigitТumber * ten;
            //int sumOfNumbers = dozenOfTwoВigitТumber + singleOgtwoВigitТumber;
            //int multiplicationOfNumbers = dozenOfTwoВigitТumber * singleOgtwoВigitТumber;

            //Console.WriteLine("\nчисло десятков в нем: " + dozenOfTwoВigitТumber + "\nчисло единиц в нем: " + singleOgtwoВigitТumber + "\nсумму его цифр: " + sumOfNumbers + "\nпроизведение его цифр: " + multiplicationOfNumbers );
            //Console.ReadLine();

            //Console.WriteLine("Задание 6");
            //Console.WriteLine("Введите четырехзначное число: ");
            //int fourВigitТumber = Convert.ToInt32(Console.ReadLine());

            //int hundred = 100,thousand = 1000;
            int ten = 10, hundred = 100, thousand = 1000; // если певидущие задания коментировать или удалять

            //int dozenOfFourВigitТumber = fourВigitТumber  / thousand;
            //int singleOfFourВigitТumber = fourВigitТumber / hundred - dozenOfFourВigitТumber * ten;
            //int hundredthOfFourВigitТumber = fourВigitТumber / ten - dozenOfFourВigitТumber * hundred - singleOfFourВigitТumber * ten;
            //int thousandthOfFourВigitТumber = fourВigitТumber - dozenOfFourВigitТumber * thousand - singleOfFourВigitТumber * hundred - hundredthOfFourВigitТumber * ten;

            //int sumOfFourВigitТumberNumbers = dozenOfFourВigitТumber + singleOfFourВigitТumber + hundredthOfFourВigitТumber + thousandthOfFourВigitТumber;
            //int multiplicationOfFourВigitТumberNumbers = dozenOfFourВigitТumber * singleOfFourВigitТumber * hundredthOfFourВigitТumber * thousandthOfFourВigitТumber;

            //Console.WriteLine("\nсумма его цифр: " + sumOfFourВigitТumberNumbers + "\nпроизведение его цифр: " + multiplicationOfFourВigitТumberNumbers);
            //Console.ReadLine();

            Console.WriteLine("Задание 6");
            Console.WriteLine("услове задачи:\n	В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.");
            Console.WriteLine("\nДано число 456");
            int threeВigitТumber = 456;
            int dozenOfThreeВigitТumber = threeВigitТumber / thousand;
            int singleOfThreeВigitТumber = threeВigitТumber / ;
            
        }
    }
}

//int.Parse(строка) - из string в int
//decimal - что это








//Console.Write("Введите имя:");
//string name;
//name = Console.ReadLine();
////Console.WriteLine(name);

//Console.ReadLine();

//int[] numbers = { 1, 2, 3, 4, 5 };

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}
