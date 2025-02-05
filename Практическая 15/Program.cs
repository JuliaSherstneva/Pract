/* 4. Ввести трёхзначное число. 
а) верно ли, что все его цифры одинаковые?
б) является ли произведение его цифр трёхзначным числом;
в) кратна ли сумма его цифр введенному числу A. */

using ClassLibrary1;

namespace Практическая_15
{
    class Program
    {
        static void Main(string[] args)
        {
Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число A: "); // Ввод числа A
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Все цифры одинаковые: {Class1.Same(number)}");
        Console.WriteLine($"Произведение цифр является трехзначным: {Class1.ProductThree(number)}");
        Console.WriteLine($"Сумма цифр кратна A: {Class1.SumA(number, A)}");
        }
    }
}

