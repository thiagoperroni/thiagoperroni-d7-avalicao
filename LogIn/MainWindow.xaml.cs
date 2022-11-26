using System.Windows;

namespace LogIn
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(email.Text == "admin@email.com" && password.Password == "admin123")
            {
                message.Text = "Usuário autenticado!";
            }
            else
            {
                message.Text = "Credenciais inválidas!";
            }

            message.Visibility = Visibility.Visible;
        }
    }
}
