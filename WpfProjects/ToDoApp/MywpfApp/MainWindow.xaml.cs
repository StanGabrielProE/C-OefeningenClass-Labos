using System.Windows;
using System.Windows.Controls;

namespace MywpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //   Button button = new Button();
            //button.Content = "Button";
            //Grid.SetColumn(button, 1);
            //Grid.SetRow(button , 3);
            //Grid grid =(Grid) FindName("myGrid");
            //grid.Children.Add(button);

        }

        private void CreateToDoBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBlock text = new TextBlock();
             if (ToDoText.Text.Length > 0) 
            {
                text.Text =ToDoText.Text;
                ToDoList.Children.Add(text); 
                ToDoText.Text = "";
            }else 
            {
                MessageBox.Show("you need to have at least 1 char ","",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}