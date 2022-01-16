// Коробчук А.
/* 3. Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;                                              :)
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);     :)
в) отсортировать список по возрасту студента;                                                             :(
г) *отсортировать список по курсу и возрасту студента;                                                    :(
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("E:\\Programming\\CSharp1\\Lesson6\\Home\\3\\Students.csv");
        int c = 0;
        List<Student> list = new List<Student>();
        while (!sr.EndOfStream)
        {
            string[] s = sr.ReadLine().Split(';');
            Student st = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]);
            list.Add(st);
            if (int.Parse(s[6]) == 5 || int.Parse(s[6]) == 6) c++;
            if (int.Parse(s[5]) >= 18 & int.Parse(s[5]) <= 20)
            {
                File.AppendAllText("E:\\Programming\\CSharp1\\Lesson6\\Home\\3\\Student", s[0] + " " + s[1] + " " + s[5] + " " + s[6] + "\n");
            }
        }
        Console.WriteLine(c);

        var col2 =
                    File.ReadAllText("E:\\Programming\\CSharp1\\Lesson6\\Home\\3\\Student")
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .GroupBy(e => e)
                    .Select(e => (e.Key, e.Count()))
                    .ToList();
        File.WriteAllText("E:\\Programming\\CSharp1\\Lesson6\\Home\\3\\Student", "");
        Console.WriteLine($"{String.Join('\n', col2)}");
    }


}

