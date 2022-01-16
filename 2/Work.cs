using System;
using System.IO;
namespace DoubleBinary
{
    class Work
    {

        public static double F(double x, double a, double b, double c)
        {
            Console.Write("Введите 0, если хотите найти минимум функции вида: a* x*x+x*b+c; 1 - если: (x+a)*(b+c); 2 - если: (x*a+x*b+x*c)*(x*a+x*b+x*c); 3 - если: (x*a+x*b+x*c)/2: ");
            int k = Convert.ToInt32(Console.ReadLine());
            double[] function = new double[4];
            function[0] = a * x * x + x * b + c;
            function[1] = (x + a) * (b + c);
            function[2] = (x * a + x * b + x * c) * (x * a + x * b + x * c);
            function[3] = (x * a + x * b + x * c) / 2;
            if (k == 0)
            {
                return function[0];
            }
            else if (k == 1)
            {
                return function[1];
            }
            else if (k == 2)
            {
                return function[2];
            }
            else
            {
                return function[3];
            }
        }


        public void SaveFunc(string fileName, double k, double l)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = k;
            bw.Write(F(x, a, b, c));
            while (x <= l)
            {

                x++;
            }
            bw.Close();
            fs.Close();
        }
        // public  void SaveFunc(string fileName, double a, double b, double h)
        // {
        //     FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        //     BinaryWriter bw = new BinaryWriter(fs);
        //     while (a <= b)
        //     {
        //         bw.Write(F(a));
        //         a += h;
        //     }
        //     bw.Close();
        //     fs.Close();
        // }
        public double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

    }
}