using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pract20;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void mItExit_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void mItInfo_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Практическая работа 20\r\n" + "Генерировать случайные числа Х,\n•  распределенные в диапазоне от -5 до 5 и вычислять для \r\nчисел > 0 Корень(x)\n• " +
                " а для чисел < 0 функцию x^2.\r\n На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках.\r\n",
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

    private void btnGenerationValue_Click(object sender, RoutedEventArgs e)
    {

        txtBoxValue.Clear();      

        if (int.TryParse(txtBoxVal.Text, out int count))
        {
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                txtBoxValue.Text += Math.Round(rnd.NextDouble() * 10 - 5 )+ "  ";               
            }
        }
        else
        {
            MessageBox.Show("Введите корректное значение!*",
                            "Ошибка (*Вы дурак)",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
        } 
        
    }

    private void btnResult_Click(object sender, RoutedEventArgs e)
    {       
        string inputText = txtBoxValue.Text;
        string[] numbers = inputText.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries); 

        foreach (string numberString in numbers)
        {
            double currentValue;

            if (double.TryParse(numberString, out currentValue))
            {
                if (currentValue > 0)
                {
                    double sqrt = Math.Round(Math.Sqrt(currentValue), 1); 
                    txtBoxResult1.Text += "   " + sqrt.ToString();
                }
                else if (currentValue < 0) 
                {
                    double pow = Math.Round(Math.Pow(currentValue, 2), 1);  
                    txtBoxResult2.Text += "   " + pow.ToString();
                }

            }
            else
            {
                MessageBox.Show("Введите корректное значение!*",
                             "Ошибка (*Вы дурак)",
                             MessageBoxButton.OK,
                             MessageBoxImage.Error);
            }
        }
    }

    private void btnClearValue_Click(object sender, RoutedEventArgs e)
    {
        txtBoxVal.Clear();
        txtBoxValue.Clear();
        txtBoxResult1.Clear();
        txtBoxResult2.Clear();
    }
}
