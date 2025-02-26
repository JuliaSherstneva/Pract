/*4. Описать процедуру TrianglePS(a, P, S), вычисляющую по стороне a 
равностороннего треугольника его периметр P = 3·a и площадь S = а²*√3/4
(a — входной, P и S — выходные параметры; все параметры являются вещественными). 
С помощью этой процедуры найти периметры и площади трех равносторонних треугольников сданными 
сторонами.*/

class Program
{

    // Функция для вычисления периметра и площади равностороннего треугольника
    static void TrianglePS(double a, out double P, out double S)
    {
        P = 3 * a; // Периметр
        S = (a * a * Math.Sqrt(3)) / 4; // Площадь
    }
    static void Main(string[] args)
    {
        double[] sides = new double[3]; // Массив для хранения сторон треугольников
        for (int i = 0; i < 3; i++) // Ввод сторон для трех треугольников
        {
            Console.WriteLine($"Введите сторону a для треугольника {i + 1}:");
            sides[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < 3; i++) // Вычисление и вывод периметров и площадей треугольников
        {
            double perimeter, area;
            TrianglePS(sides[i], out perimeter, out area);
            Console.WriteLine($"Треугольник {i + 1}: P = {perimeter}, S = {area}");
        }
    }
}