namespace OPP.Pr26
{
    public class Rectangle : Figure
    {
        private double _width;
        private double _height;

        // Конструктор
        public Rectangle(string color, (double x, double y) coordinates, double width, double height) : base(color, coordinates)
        {
            _width = width;
            _height = height;
        }

        // Переопределяем метод "CalculateArea"
        public override double CalculateArea()
        {
            return _width * _height;
        }
    }
}
