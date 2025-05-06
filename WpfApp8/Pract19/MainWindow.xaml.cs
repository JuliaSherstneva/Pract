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

namespace Pract19;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnAddValue_Click(object sender, RoutedEventArgs e)
    {
        lBoxValues.Items.Add(txtBoxValue.Text);
    }

    private void btnDeleteValue_Click(object sender, RoutedEventArgs e)
    {
        lBoxValues.Items.Remove(lBoxValues.SelectedItem);
    }

    private void btnClearValue_Click(object sender, RoutedEventArgs e)
    {
        lBoxValues.Items.Clear();
    }

    private void btnResult_Click(object sender, RoutedEventArgs e)
    {
        //Ввести n целых чисел. Вычислить для чисел > 0 функцию Корень(x). Результат обработки каждого числа вывести на экран.
        double Sqrt = 0;

        for (int i = 0; i < lBoxValues.Items.Count; i++)
        {
            double currentValue = Convert.ToDouble(lBoxValues.Items[i]);

            if (currentValue >0)
            {
                Sqrt = Math.Round(Math.Sqrt(currentValue)); 
                txtBoxResult.Text += " " +Sqrt.ToString();
            }
        }

       
    }

    private void btnGenerateValues_Click(object sender, RoutedEventArgs e)
    {
        lBoxValues.Items.Clear();

        if (int.TryParse(txtBoxValues.Text, out int count))
        {
            Random rnd = new Random();

            for (int i=0; i< count; i++)
            {
                lBoxValues.Items.Add(rnd.Next(333) / 10.0);
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