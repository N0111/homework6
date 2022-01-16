// Коробчук А.
/* 
2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделать меню с различными функциями и представить пользователю выбор,
для какой функции и на каком отрезке находить минимум. Использовать массив
(или список) делегатов, в котором хранятся различные функции.
*/


using System;
using System.IO;
namespace DoubleBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Work fun = new Work();
            Console.Write("Введите максимальное значение: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальное значение: ");
            int b = Convert.ToInt32(Console.ReadLine());

            fun.SaveFunc("data.bin", b, a);
            Console.WriteLine(fun.Load("data.bin"));
        }
    }
}