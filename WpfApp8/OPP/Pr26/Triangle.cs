namespace OPP.Pr26
{
    class Triangle : Figure
    {
        private double _base;
        private double _height;

        // Конструктор
        public Triangle(string color, (double x, double y) coordinates, double baseLength, double height) : base(color, coordinates)
        {
            _base = baseLength;
            _height = height;
        }

        // Переопределяем метод "CalculateArea"
        public override double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }
}
