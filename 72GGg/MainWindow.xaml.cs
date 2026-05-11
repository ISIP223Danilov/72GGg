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
using static _72GGg.fynkcya;
namespace _72GGg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        // Кнопка "Зашифровать"
        private void EncodeButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            string encoded = Rot13(input);
            OutputTextBox.Text = encoded;
        }

        // Кнопка "Расшифровать" (делает то же самое, так как ROT13 самодвойственен)
        private void DecodeButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            string decoded = Rot13(input);
            OutputTextBox.Text = decoded;
        }
    

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
