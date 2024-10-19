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

namespace dobbelsteen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        int number = 0;
        Random random = new Random();
        int numberRoll = 0;


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            while(number != 6)
            {
                numberRoll++;
                number = random.Next(1,7);
                rollTextBox.Text += $"Worp {numberRoll} geeft " + $"{number}\n";
            }
        }

        private void repeatButton_Click(object sender, RoutedEventArgs e)
        {
            rollTextBox.Clear();
            number = 0;
            numberRoll = 0;
            number++;
            number = random.Next(0,7);
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}