using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool start = true;
        public ObservableCollection<MyClass> data = new ObservableCollection<MyClass>();
        public MainWindow()
        {
            InitializeComponent();
            GetData();
            DataContext = data;
        }
        public MainWindow(bool o)
        {
            start = false;
        }
        public ObservableCollection<MyClass> GetData() 
        {
            data.Add(new MyClass("Willa", "Cather", 18));
            data.Add(new MyClass("Isak", "Dinesen", 22));
            data.Add(new MyClass("Victor", "Hugo", 10));
            data.Add(new MyClass("Jules", "Verne", 20));

            return data;
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addW = new AddWindow();
            addW.ShowDialog();
            data.Add(new MyClass(addW.NameTextbox.Text, addW.SurnameTextbox.Text, Convert.ToInt32(addW.AgeTextbox.Text)));
            DataContext = data;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            DelWindow delWindow = new DelWindow();
            delWindow.ShowDialog();
            string _name= delWindow.delTextBox.Text;
            foreach (var item in data)
            {
                if (item.Name == _name)
                {
                    data.Remove(item);
                    break;
                }
            }
        }
    }
}
