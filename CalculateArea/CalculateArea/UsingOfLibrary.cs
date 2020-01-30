using System;
using FigureArea;

namespace CalculateArea
{
    class UsingOfLibrary
    {
        static void Main(string[] args)
        {
            IAreable circle = new Circle(5);
            IAreable triangle = new Triangle(3, 4, 5);
            IAreable triangle2 = new Triangle(4, 5, 6);
            Console.WriteLine("Площадь круга = " + circle.CalculateArea());
            Console.WriteLine("Площадь треугольника = " + triangle.CalculateArea());
            Console.WriteLine("Треугольник " + (((Triangle)triangle).IsRectangular() ? "" : "не ") + "является прямоугольным");
            Console.WriteLine("Площадь треугольника = " + triangle2.CalculateArea());
            Console.WriteLine("Треугольник " + (((Triangle)triangle2).IsRectangular() ? "" : "не ") + "является прямоугольным");
            //Для того, чтоб избежать приведения типов, можно было абстрактный родительский класс сделать, с методом Show(), реализованным у каждого по-своему.
            //В таком случае интерфейс не нужен был бы, т.к. метод CalculateArea лежал бы в родительском классе абстрактно, но т.к. в задаче нет уточнений на эту тему
            //то было принятно решение сделать через интерфейсы, а вывод и остальное на усмотрение внешнего приложения/пользователя оставить.
        }
    }
}
