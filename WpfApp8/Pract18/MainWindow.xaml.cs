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

namespace Pract18;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAuto_Click(object sender, RoutedEventArgs e)
        { 
            if (cbAuto.IsChecked.Value)
            {
                gbAuto.IsEnabled = true;
            }
            else if (!cbAuto.IsChecked.Value)
            {
                gbAuto.IsEnabled = false;
            }    
        }

        private void rbAuto1_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Рабочий день";
        }
        private void rbAuto2_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Рабочий день";
        }
        private void rbAuto3_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Рабочий день";
        }
        private void rbAuto4_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Рабочий день";
        }
        private void rbAuto5_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Рабочий день";
        }
        private void rbAuto6_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Выходной";
        }
        private void rbAuto7_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxResultAuto.Text = "Выходной";
        }

        private void cbManual_Click(object sender, RoutedEventArgs e)
        {
            if (cbManual.IsChecked.Value)
            {
                gbManual.IsEnabled = true;
            }
            else
            {
                gbManual.IsEnabled = false;
            }
        }
    
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            if (rbManual1.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Рабочий день";
            }
            else if (rbManual2.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Рабочий день";
            }
            else if (rbManual3.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Рабочий день";
            }
            else if (rbManual4.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Рабочий день";
            }
            else if (rbManual5.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Рабочий день";
            }
            else if (rbManual6.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Выходной";
            }
            else if (rbManual7.IsChecked.Value)
            {
                txtBoxResultManual.Text = "Выходной";
            }
        }
    }
