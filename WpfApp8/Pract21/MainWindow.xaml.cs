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

namespace Pract21;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int[]? mas;
    int[,]? matr;

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
        MessageBox.Show("Практическая работа 21\r\n" + "*Задача 1\r\n" + "Ввести n целых чисел.\n• Вычислить для чисел > 0 функцию Корень(x). " +
            "\n• Результат обработки каждого числа вывести на экран.\n" + "*Задача 2\r\n" +
            "Дана целочисленная матрица размера M * N.\n• Найти количество ее столбцов, все элементы \r\nкоторых различны.",
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

    private void btnFill_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txtBoxRange.Text, out int range))
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(range);
            }
            dgOneArray.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
    }

    private void btnCreate_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txtBoxCount.Text, out int count))
        {
            mas = new int[count];
            dgOneArray.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
        else
        {
            MessageBox.Show("Введите корректное значение!*",
                           "Ошибочка",
                           MessageBoxButton.OK,
                           MessageBoxImage.Error);
        }
    }

    private void btnResult_Click(object sender, RoutedEventArgs e)
    {
        double Sqrt = 0;

        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > 0)
            {
                double sqrt = Math.Round(Math.Sqrt(mas[i]));
                txtBoxResult.Text += " " + sqrt.ToString();
            }
            else
            {
                MessageBox.Show("Сначала создайте и заполните массив!",
                              "Ошибочка",
                              MessageBoxButton.OK,
                              MessageBoxImage.Error);
            }
        }
    }
    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        mas = null;
        dgOneArray.ItemsSource = mas;
        txtBoxCount.Clear();
        txtBoxRange.Clear();
        txtBoxResult.Clear();
    }

    private void btnCreate2_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txtBoxColumn2.Text, out int rowCount) &&
           int.TryParse(txtBoxRow2.Text,     out int columnCount))
        {
            matr = new int[rowCount, columnCount];
            dgTwoArray.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
        }
        else
        {
            MessageBox.Show("Введите корректное значение!*",
                           "Ошибочка",
                           MessageBoxButton.OK,
                           MessageBoxImage.Error);
        }
    }

    private void btnFill2_Click(object sender, RoutedEventArgs e)
    {
        if(int.TryParse(txtBoxColumn2.Text,   out int rowCount) &&
           int.TryParse(txtBoxRow2.Text,      out int columnCount) &&
           int.TryParse(txtBoxRange2.Text,    out int range))
        {
            Random random = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = random.Next(range);
                }
            }
            dgTwoArray.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
        }    
    }

    private void btnResult2_Click(object sender, RoutedEventArgs e)
    {
        int uniqueColumnCount = 0; 

        if (matr != null) 
        {
            int rows = matr.GetLength(0);
            int cols = matr.GetLength(1);

            for (int j = 0; j < cols; j++) 
            {
                bool isUnique = true; 
                HashSet<int> columnElements = new HashSet<int>(); 

                for (int i = 0; i < rows; i++) 
                {
                    if (!columnElements.Add(matr[i, j])) 
                    {                
                        isUnique = false;                       
                    }
                }
                if (isUnique)
                {
                    uniqueColumnCount++; 
                }
            }
            txtBoxResult2.Text = uniqueColumnCount.ToString(); 
        }
        else
        {
            MessageBox.Show("Сначала создайте и заполните массив!",
                          "Ошибочка",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
        }
    }
      

    private void btnClear2_Click(object sender, RoutedEventArgs e)
    {
        matr = null;
        dgTwoArray.ItemsSource = matr;
        txtBoxRow2.Clear();
        txtBoxColumn2.Clear();
        txtBoxRange2.Clear();
        txtBoxResult2.Clear();
    }
}

