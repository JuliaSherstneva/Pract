using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Pract23;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Polygon K;
    Polygon I;
    Polygon T;
    Polygon Spina;
    Polygon Givot1, Givot2;
    Polygon Eye;
    Polygon Zrachok;

    public MainWindow()
    {
        InitializeComponent();

      K       = new Polygon();
      I       = new Polygon();
      T       = new Polygon();
      Spina   = new Polygon();
      Givot1  = new Polygon();
      Givot2  = new Polygon();
      Eye     = new Polygon();
      Zrachok = new Polygon();
    }

    private void mItExit_Click(object sender, RoutedEventArgs e)
    {
        Close();

    }

    private void mItInfo_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Практическая работа 23\r\n" + "Задача:\r\n" + "КИТ",
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

    private void mltPaint_Click(object sender, RoutedEventArgs e)
    {
        // КИТ

        K.Stroke = Brushes.Blue;
        I.Stroke = Brushes.Blue;
        T.Stroke = Brushes.Blue;

        Spina.Stroke = Brushes.Blue;

        Givot1.Stroke = Brushes.Gray;
        Givot2.Stroke = Brushes.Gray;

        Eye.Stroke = Brushes.Black;
        Zrachok.Stroke = Brushes.White;

        K.Fill = Brushes.Blue;//Заливка
        I.Fill = Brushes.Blue;
        T.Fill = Brushes.Blue;

        Spina.Fill = Brushes.Blue;

        Givot1.Fill = Brushes.Gray;
        Givot2.Fill = Brushes.Gray;

        Eye.Fill = Brushes.Black;
        Zrachok.Fill = Brushes.White;

        K      .StrokeThickness = 3;
        I      .StrokeThickness = 3;
        T      .StrokeThickness = 3;
                                  
        Spina  .StrokeThickness = 3;
                                  
        Givot1 .StrokeThickness = 3;
        Givot2 .StrokeThickness = 3;
                                  
        Eye    .StrokeThickness = 3;
        Zrachok.StrokeThickness = 3;

        // К

        K.Points.Add(new Point(80,20));
        K.Points.Add(new Point(100,20));
        K.Points.Add(new Point(100,50));
        K.Points.Add(new Point(110,50));
       // K.Points.Add(new Point(110,30));
       // K.Points.Add(new Point(120,30));
        K.Points.Add(new Point(120,20));
        K.Points.Add(new Point(140,20));
       // K.Points.Add(new Point(140,30));
       // K.Points.Add(new Point(130,30));
       // K.Points.Add(new Point(130,50));
        K.Points.Add(new Point(125,50));
        K.Points.Add(new Point(125,60));
       // K.Points.Add(new Point(130,60));
       // K.Points.Add(new Point(130,80));
       // K.Points.Add(new Point(140,80));
        K.Points.Add(new Point(140,100));
        K.Points.Add(new Point(120,100));
       // K.Points.Add(new Point(120,80));
       // K.Points.Add(new Point(110,80));
        K.Points.Add(new Point(110,60));
        K.Points.Add(new Point(100,60));
        K.Points.Add(new Point(100,100));
        K.Points.Add(new Point(80,100));
        K.Points.Add(new Point(80, 20));

        // И

        I.Points.Add(new Point(180, 20));
        I.Points.Add(new Point(200, 20));
        I.Points.Add(new Point(200, 60));
       // I.Points.Add(new Point(210, 50));
       // I.Points.Add(new Point(210, 30));
       // I.Points.Add(new Point(220, 30));
        I.Points.Add(new Point(220, 20));
        I.Points.Add(new Point(240, 20));
        I.Points.Add(new Point(240, 100));
        I.Points.Add(new Point(220, 100));
        I.Points.Add(new Point(220, 60));
       // I.Points.Add(new Point(210, 70));
       // I.Points.Add(new Point(210, 90));
       // I.Points.Add(new Point(200, 90));
        I.Points.Add(new Point(200, 100));
        I.Points.Add(new Point(180, 100));
        I.Points.Add(new Point(180, 20));

        // Т

        T.Points.Add(new Point(280, 20));
        T.Points.Add(new Point(340, 20));
        T.Points.Add(new Point(340, 35));
        T.Points.Add(new Point(320, 35));
        T.Points.Add(new Point(320, 100));
        T.Points.Add(new Point(300, 100));
        T.Points.Add(new Point(300, 35));
        T.Points.Add(new Point(280, 35));
        T.Points.Add(new Point(280, 20));

        // Spina

        Spina.Points.Add(new Point(150, 150));
        Spina.Points.Add(new Point(180, 160));
        Spina.Points.Add(new Point(200, 170));
        Spina.Points.Add(new Point(210, 190));
        Spina.Points.Add(new Point(240, 190));
        Spina.Points.Add(new Point(290, 210));
        Spina.Points.Add(new Point(230, 230));
        Spina.Points.Add(new Point(200, 220));
        Spina.Points.Add(new Point(190, 230));
        Spina.Points.Add(new Point(190, 260));
        Spina.Points.Add(new Point(210, 290));
        Spina.Points.Add(new Point(280, 310));
        Spina.Points.Add(new Point(380, 320));
        Spina.Points.Add(new Point(410, 350));
        Spina.Points.Add(new Point(430, 380));
        Spina.Points.Add(new Point(430, 470));
        Spina.Points.Add(new Point(410, 490));
        Spina.Points.Add(new Point(380, 500));
        Spina.Points.Add(new Point(310, 490));
        Spina.Points.Add(new Point(200, 450));
        Spina.Points.Add(new Point(180, 460));
        Spina.Points.Add(new Point(120, 460));
        Spina.Points.Add(new Point(80, 410));
        Spina.Points.Add(new Point(90, 400));
        Spina.Points.Add(new Point(150, 400));
        Spina.Points.Add(new Point(130, 380));
        Spina.Points.Add(new Point(120, 340));
        Spina.Points.Add(new Point(130, 300));
        Spina.Points.Add(new Point(150, 250));
        Spina.Points.Add(new Point(170, 230));
        Spina.Points.Add(new Point(180, 210));
        Spina.Points.Add(new Point(160, 180));

        // Живот

        Givot1.Points.Add(new Point(120, 345));
        Givot1.Points.Add(new Point(130, 380));
        Givot1.Points.Add(new Point(150, 400));
        Givot1.Points.Add(new Point(130, 400));
        Givot1.Points.Add(new Point(120, 380));

        Givot2.Points.Add(new Point(180, 460));
        Givot2.Points.Add(new Point(200, 450));
        Givot2.Points.Add(new Point(240, 465));
        Givot2.Points.Add(new Point(270, 475));
        Givot2.Points.Add(new Point(310, 490));
        Givot2.Points.Add(new Point(380, 500));
        Givot2.Points.Add(new Point(350, 510));
        Givot2.Points.Add(new Point(290, 510));

        // Глаз

        Eye.Points.Add(new Point(270, 425));
        Eye.Points.Add(new Point(270, 445));
        Eye.Points.Add(new Point(290, 450));
        Eye.Points.Add(new Point(290, 420));

        // Зрачок

        Zrachok.Points.Add(new Point(280, 430));
        Zrachok.Points.Add(new Point(280, 440));
        Zrachok.Points.Add(new Point(290, 440));
        Zrachok.Points.Add(new Point(290, 430));

        if (canvas.Children.Count == 0)
        {
            canvas.Children.Add(K);
            canvas.Children.Add(I);
            canvas.Children.Add(T);
            canvas.Children.Add(Spina);
            canvas.Children.Add(Givot1);
            canvas.Children.Add(Givot2);
            canvas.Children.Add(Eye);
            canvas.Children.Add(Zrachok);
        }
    }

    private void mltClear_Click(object sender, RoutedEventArgs e)
    {
        canvas.Children.Remove(K);
        canvas.Children.Remove(I);
        canvas.Children.Remove(T);
        canvas.Children.Remove(Spina);
        canvas.Children.Remove(Givot1);
        canvas.Children.Remove(Givot2);
        canvas.Children.Remove(Eye);
        canvas.Children.Remove(Zrachok);
    }

    private void mltColor_Click(object sender, RoutedEventArgs e)
    {
        K.Stroke = Brushes.Gray;
        I.Stroke = Brushes.Gray;
        T.Stroke = Brushes.Gray;
        
        Spina.Stroke = Brushes.Gray;
        
        Givot1.Stroke = Brushes.LightGray;
        Givot2.Stroke = Brushes.LightGray;

        Eye.Stroke = Brushes.Black;
        Zrachok.Stroke = Brushes.White;

        K.Fill = Brushes.Gray;//Заливка
        I.Fill = Brushes.Gray;
        T.Fill = Brushes.Gray;
        
        Spina.Fill = Brushes.Gray;
        
        Givot1.Fill = Brushes.LightGray;
        Givot2.Fill = Brushes.LightGray;

        Eye.Fill = Brushes.Black;
        Zrachok.Fill = Brushes.White;
    }
}

