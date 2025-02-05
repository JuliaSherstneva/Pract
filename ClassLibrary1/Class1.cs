namespace ClassLibrary1
{
    public class Class1
    {
        public static bool Same(int number) //Проверка равенства
        {
            int first = number / 100; // Получаем первую цифру
            int second = (number / 10) % 10; // Получаем вторую цифру
            int third = number % 10; // Получаем третью цифру
            return first == second && second == third;
        }
        public static int Product(int number) //Вычисление произведения
        {
            int first = number / 100;
            int second = (number / 10) % 10;
            int third = number % 10;
            return first * second * third;
        }
        public static bool ProductThree(int number) //Проверка на трёхзначначность произведения 
        {
            int product = Product(number);
            return product >= 100 && product <= 999;
        }
        public static bool SumA(int number, int A) //Проверка на кратность
        {
            int first = number / 100;
            int second = (number / 10) % 10;
            int third = number % 10;
            int sum = first + second + third;
            return sum % A == 0;
        }
    }
}
