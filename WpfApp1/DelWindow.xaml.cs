using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для DelWindow.xaml
    /// </summary>
    public partial class DelWindow : Window
    {
        public DelWindow()
        {
            InitializeComponent();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
