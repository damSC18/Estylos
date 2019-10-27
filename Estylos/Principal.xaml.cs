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
using System.Windows.Shapes;

namespace Estylos
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EstiloApp_Click(object sender, RoutedEventArgs e)
        {
            new EstiloAppXaml().Show();
        }

        private void EstiloExterno_Click(object sender, RoutedEventArgs e)
        {
            new VentanaEstiloExterno().Show();
        }

        private void MaterialD_Click(object sender, RoutedEventArgs e)
        {
            new MaterialD().Show();
        }
    }
}
