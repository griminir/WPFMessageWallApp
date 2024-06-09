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

namespace WPFMessageWall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<string> _messages = new BindingList<string>();
        public MainWindow()
        {
            InitializeComponent();

            MessageList.ItemsSource = _messages;
        }

        private void AddMessage_Click(object sender, RoutedEventArgs e)
        {
            _messages.Add(MessageText.Text);
            MessageText.Text = "";
        }
    }
}