namespace OPP.Pr25
{
    public class Emoji
    {
        // Поля
        private string _name;
        private string _description;
        private char _unicode;
        
        // Поле для хранения "скопированного" символа
        private char _clipboard;

        // Свойства
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название не может быть пустым.");
                }
                _name = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Описание не может быть пустым.");
                }
                _description = value;
            }
        }

        public char Unicode
        {
            get { return _unicode; }
            set
            {
              

                _unicode = value;
            }
        }

        public char Clipboard
        {
            get { return _clipboard; }
            set
            {               
                _clipboard = value;
            }
        }

        // Конструктор
        public Emoji(string name, string description, char unicode)
        {
            Name = name;
            Description = description;
            Unicode = unicode;
            Clipboard = '\0';
        }

        // Метод "Отправить"
        public void Send()
        {
            Console.WriteLine($"Эмодзи '{Name}' отправлено: {Unicode}");
        }

        // Метод "Скопировать"
        public void Copy()
        {
            Clipboard = Unicode; // копируем
            Console.WriteLine($"Эмодзи '{Name}' скопировано: {Unicode}");
        }

        // Переопределение ToString для вывода информации
        public override string ToString()
        {
            return $"Название: {Name}\nОписание: {Description}\nUnicode: {Unicode}";
        }
    }
}
