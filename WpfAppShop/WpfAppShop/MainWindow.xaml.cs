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

namespace WpfAppShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //вывод логотипа компании
            ImageLogo.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath("../../Resources/logoCompany.png")));
        }


        //кнопка авторизации пользователя
        private void Button_auth_Click(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrEmpty(logintextBox.Text))
            {
                if (!String.IsNullOrEmpty(passwordTextBox.Password))
                {
                    IQueryable<Worker> worker_list = Entities.GetContext().Worker.Where(p => p.Login == logintextBox.Text && p.Password == passwordTextBox.Password);
                    if (worker_list.Count() == 1)
                    {
                        MessageBox.Show("Добро пожаловать," + worker_list.First().FirstName);
                        GlavnoeWindow window = new GlavnoeWindow(worker_list.First());
                        window.Owner = this;
                        window.Show();
                        this.Hide();

                    }
                    //всплывающее окно при неверно введеных данных
                    else MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }
    }
}
