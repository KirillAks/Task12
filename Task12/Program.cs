using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        //метод, определяющий длину окружности по заданному радиусу;
        //метод, определяющий площадь круга по заданному радиусу;
        //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.

        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности r = ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            double circumference = Circle.GetCircumference(r);
            double square = Circle.GetSquare(r);
            string belonging = Circle.ToBelong(x, y, r);
            Console.WriteLine("Длина окружности равна {0}", circumference);
            Console.WriteLine("Площадь круга равна {0}", square);
            Console.WriteLine(belonging);
            Console.ReadKey();
        }
    }
}
