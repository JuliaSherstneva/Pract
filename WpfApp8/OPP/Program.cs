using OPP.Pr25;
using System.Text; // подключение пространства имен с классом Emoji

Console.OutputEncoding = Encoding.Unicode;
// Создаем объект эмодзи
Emoji smileEmoji = new Emoji("Улыбающееся лицо", "Выражает радость и улыбку", '\u263A'); //😄

// Вывод информации о эмодзи
Console.WriteLine($"Информация о эмоджи:\n{smileEmoji}\n");

smileEmoji.Copy();   // копируем
smileEmoji.Send();   // отправляем
        
