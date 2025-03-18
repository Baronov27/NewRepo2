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
using forms.Model;

namespace forms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Users> _users;
        
        public MainWindow()
        {
            InitializeComponent();

            _users = new List<Users>()
            {
                new Users("2", "333"),
                new Users("123", "0000"),

            };

        }

        public bool Get(string login, string pass)
        {
           var user = _users.FirstOrDefault(u => u.Login == login && u.Pass == pass);

            if (user != null && user.Pass == pass && user.Login==login)
            {
                return true;
            }

            return false;
        }

        private void ButtonNewWindow_Click(object sender, RoutedEventArgs e)
        {
 
            string login=tbxLogin.Text;
            string password=tbxPassword.Text;
            if(Get(login,password))
            {
                Window wind=new User1();
                wind.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль","Ошибка",MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
