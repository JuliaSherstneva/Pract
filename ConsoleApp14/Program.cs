/* 4. Описать функцию RingS(R1, R2) вещественного типа, находящую площадь 
кольца, заключенного между двумя окружностями с общим центром и радиусами R1 и R2 
(R1 и R2 — вещественные, R1 > R2). С ее помощью найти площади трех колец, для 
которых даны внешние и внутренние радиусы. Воспользоваться формулой площади круга 
радиуса R: S = 3.14·R2
В качестве значения . использовать 3.14. */

class Program
{
    static double RingS(double r1, double r2) // Функция для вычисления площади кольца
    {

        double areaOuter = 3.14 * r1 * r1; // Площадь внешней окружности       
        double areaInner = 3.14 * r2 * r2; // Площадь внутренней окружности
        return areaOuter - areaInner; // Площадь кольца
    }
    static void Main(string[] args)
    {
        double[,] radii = new double[3, 2];
        for (int i = 0; i < 3; i++) // Ввод радиусов для трех колец
        {
            Console.WriteLine($"Введите внешний радиус R1 для кольца {i + 1}:");
            radii[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите внутренний радиус R2 для кольца {i + 1}:");
            radii[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < 3; i++) // Вычисление и вывод площадей колец
        {
            if (radii[i, 0] > radii[i, 1]) // Проверка условия R1 > R2
            {
                double area = RingS(radii[i, 0], radii[i, 1]);
                Console.WriteLine($"Площадь кольца {i + 1}: {area}");
            }
            else
            {
                Console.WriteLine($"Ошибка: R1 меньше R2 {i + 1}.");
            }
        }
    }
}