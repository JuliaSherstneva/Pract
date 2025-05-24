using OPP.Pr25;
using System.Text; // подключение пространства имен с классом Emoji

/*
Console.OutputEncoding = Encoding.Unicode;
// Создаем объект эмодзи
Emoji smileEmoji = new Emoji("Улыбающееся лицо", "Выражает радость и улыбку", '\u263A'); //😄

// Вывод информации о эмодзи
Console.WriteLine($"Информация о эмоджи:\n{smileEmoji}\n");

smileEmoji.Copy();   // копируем
smileEmoji.Send();   // отправляем
*/

using OPP.Pr26;

Triangle triangle = new Triangle("синий", (0, 0), 5, 10);
Rectangle rectangle = new Rectangle("красный", (1, 1), 4, 6);

Figure[] figures = { triangle, rectangle }; // Массив фигур

foreach (Figure figure in figures)
{
    string shapeType = figure is Triangle ? "Треугольник" : "Прямоугольник";
    Console.WriteLine($"{shapeType} - Цвет: {figure.Color}, Площадь: {figure.CalculateArea()}");
}