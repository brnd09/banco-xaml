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

namespace banco_xaml
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login efetuado");
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Ajuste adicional do layout pode ser feito aqui, se necessário
        }

    }
}
