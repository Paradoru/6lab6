using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<Balbes> _Nikita;
        public MainWindow()
        {
            InitializeComponent();
            _Nikita = new Stack<Balbes>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            if (addWindow.ShowDialog() == true)
            {
                Balbes balbes = addWindow.BalbesMy;
                _Nikita.Push(balbes);
                Mountains.ItemsSource = null;
                Mountains.ItemsSource = _Nikita;    
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _Nikita.Pop();
            Mountains.ItemsSource = null;
            Mountains.ItemsSource = _Nikita;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double a = 0;
            foreach (Balbes i in _Nikita)
            {
                a += i.Height;
            }
            a /= 2;
            MessageBox.Show(a.ToString()); //a.ToString
        }
    }
}
