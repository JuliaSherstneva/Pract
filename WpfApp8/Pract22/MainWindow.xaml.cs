using Microsoft.Win32;
using System.IO;
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

namespace Pract22;

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
        MessageBox.Show("Практическая работа 22\r\n" + "*Задача 1\r\n" + "Ввести n целых чисел.\n• Вычислить для чисел > 0 функцию Корень(x). " +
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
           int.TryParse(txtBoxRow2.Text, out int columnCount))
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
        if (int.TryParse(txtBoxColumn2.Text, out int rowCount) &&
           int.TryParse(txtBoxRow2.Text, out int columnCount) &&
           int.TryParse(txtBoxRange2.Text, out int range))
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

    private void altSave_Click(object sender, RoutedEventArgs e)
    {
        //Создаём и настраиваем элемент SaveFileDialog
        SaveFileDialog save = new SaveFileDialog();
        save.DefaultExt = ".txt";
        save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
        save.FilterIndex = 2;
        save.Title = "Сохранение таблицы";

        switch (tabControl.SelectedIndex)
        {
            // Одномерный
            case 0:
                //Открываем диалоговое окно и при успехе работаем с файлом 
                if (save.ShowDialog().Value)
                {
                    //Создаём поток для работы с файлом и указываем ему имя файла
                    StreamWriter file = new StreamWriter(save.FileName);

                    //Записываем размер массива в файл
                    file.WriteLine(mas.Length);

                    //Записываем диапазон значений массива в файл
                    file.WriteLine(txtBoxRange.Text);

                    //Записываем элементы массива в файл
                    for (int i = 0; i < mas.Length; i++)
                    {
                        file.WriteLine(mas[i]);
                    }
                    file.Close();
                }
                break;

            // Двумерный
            case 1:
                if (save.ShowDialog().Value)
                {
                    //Создаём поток для работы с файлом и указываем ему имя файла
                    StreamWriter file = new StreamWriter(save.FileName);

                    //Записываем количеcтво строк в файл
                    file.WriteLine(matr.GetLength(0));

                    //Записываем количеcтво столбцов в файл
                    file.WriteLine(matr.GetLength(1));

                    //Записываем диапазон значений массива в файл
                    file.WriteLine(txtBoxRange2.Text);

                    //Записываем элементы массива в файл
                    for (int i = 0; i < matr.GetLength(0); i++)
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            file.WriteLine(matr[i, j]);
                        }
                    }
                    file.Close();
                }

                break;

            default:
                break;
        }
    }

    private void altOpen_Click(object sender, RoutedEventArgs e)
    {
        //Создаём и настраиваем элемент OpenFileDialog
        OpenFileDialog open = new OpenFileDialog();
        open.DefaultExt = ".txt";
        open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
        open.FilterIndex = 2;
        open.Title = "Открытие таблицы";

        switch (tabControl.SelectedIndex)
        {
            // Одномерный
            case 0:
                //Открываем диалоговое окно и при успехе работаем с файлом       
                if (open.ShowDialog().Value)
                {
                    //Создаём поток для работы с файлом и указываем ему имя файла
                    StreamReader file = new StreamReader(open.FileName);

                    //Читаем размер массива
                    int len = Convert.ToInt32(file.ReadLine());
                    txtBoxCount.Text = len.ToString();

                    //Читаем размер диапазон значений массива
                    int range = Convert.ToInt32(file.ReadLine());
                    txtBoxRange.Text = len.ToString();

                    //Создаём массив
                    mas = new int[len];

                    //Считываем массив из файла
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = Convert.ToInt32(file.ReadLine());
                    }
                    file.Close();

                    //Выводим массив на форму
                    dgOneArray.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                }
                break;

            // Двумерный
            case 1:
                if (open.ShowDialog().Value)
                {
                    //Создаём поток для работы с файлом и указываем ему имя файла
                    StreamReader file = new StreamReader(open.FileName);

                    //Читаем количеcтво строк массива
                    int rowCount = Convert.ToInt32(file.ReadLine());
                    txtBoxRow2.Text = rowCount.ToString();

                    //Читаем количеcтво столбцов массива
                    int colCount = Convert.ToInt32(file.ReadLine());
                    txtBoxColumn2.Text = colCount.ToString();

                    //Читаем размер диапазон значений массива
                    int range = Convert.ToInt32(file.ReadLine());
                    txtBoxRange2.Text = range.ToString();

                    //Создаём массив
                    matr = new int[rowCount, colCount];

                    //Считываем массив из файла
                    for (int i = 0; i < matr.GetLength(0); i++)
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            matr[i, j] = Convert.ToInt32(file.ReadLine());
                        }
                    }
                    file.Close();

                    //Выводим массив на форму
                    dgTwoArray.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
                }
                break;

            default:
                break;
        }

    }
}