namespace OPP.Pr26
{
    public abstract class Figure
    {
        // Поля
        private string _color;
        private (double x, double y) _coordinates;

        // Свойства
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public (double x, double y) Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }

        // Конструктор
        public Figure(string color, (double x, double y) coordinates)
        {
            Color = color;
            Coordinates = coordinates;
        }

        // Виртуальный метод
        public abstract double CalculateArea();
    }
}
