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
using System.Windows.Shapes;

namespace WpfAppShop
{
    /// <summary>
    /// Логика взаимодействия для EditBuyWindow.xaml
    /// </summary>
    public partial class EditBuyWindow : Window
    {
        public EditBuyWindow(Buy buy)
        {
            InitializeComponent();
            DataContext = buy;
            //вывод логотипа компании
            ImageLogo.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath("../../Resources/logoCompany.png")));

        }
        //кнопка сохранения изменений
        private void Edit_button_Click(object sender, RoutedEventArgs e)
        {           
            Entities.GetContext().SaveChanges();
            ((GlavnoeWindow)this.Owner).UpdateData();
            this.Close();
        }

    }
}
