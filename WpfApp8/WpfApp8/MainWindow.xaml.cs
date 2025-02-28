using System.Windows;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnResult1_Click(object sender, RoutedEventArgs e)
        {
            // V куба = a^3
            // S куба = 6 * a^2
            if (double.TryParse(txtBoxA.Text, out var a))
            {
                var v = Math.Pow(a, 3);
                txtBoxV.Text = v.ToString();
                var s = 6 * Math.Pow(a, 2);
                txtBoxS.Text = s.ToString();
            }
            else 
            {
                MessageBox.Show("Введите корректное значение", 
                                "Ошибка", 
                                MessageBoxButton.OK, 
                                MessageBoxImage.Error);
            }

        }

        private void txtBoxA_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            txtBoxV.Clear();
            txtBoxS.Clear();
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mItInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Реализовать расчет задачи:\n• Дана длина ребра куба А. Найти объем куба V и площадь его поверхности S.\n• " +
                "Дана масса M в килограммах. Используя операцию деления целых чисел, найти количество полных тонн и килограмм (1 тонна = 1000 кг).",
                            "Информация",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void mItDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Шерстнёва Ю.С.\nгр. ИСП-22",
                            "Разработчик",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void txtBoxM_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
          
        }

        private void btnResult2_Click(object sender, RoutedEventArgs e)
        {
            // 1 тонна = 1000 кг
            if (int.TryParse(txtBoxM.Text, out var M))
            {
                var T = M / 1000;           
                txtBoxT.Text = T.ToString();
                var Kg = M % 1000; 
                txtBoxKg.Text = Kg.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное значение",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }

        }
    }
}