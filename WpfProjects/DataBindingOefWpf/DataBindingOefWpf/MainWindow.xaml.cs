
using DataBindingOefWpf.Models;
using System.ComponentModel;
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

namespace DataBindingOefWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         List<Person> People { get; set; } = new()
        {
            new Person {Name ="Gabriel" , Age = 28},
            new Person {Name ="Gabriel" , Age = 28},
            new Person {Name ="Gabriel" , Age = 28},
            new Person {Name ="Gabriel" , Age = 28},
            new Person {Name ="Gabriel" , Age = 28},

        };

       
        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach(var item in selectedItems) 
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}