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
    /// Логика взаимодействия для AddBuyWindow.xaml
    /// </summary>
    public partial class AddBuyWindow : Window
    {
        private Worker worker;
        public AddBuyWindow(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            //формирование запроса к базе данных
            Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var join_massive = from buy in Entities.GetContext().Buy
                               where buy.ID_worker == worker.ID_worker
                               select buy;
            workerComboBox.ItemsSource = Entities.GetContext().Worker.ToList();
            tovarComboBox.ItemsSource = Entities.GetContext().Tovar.ToList();
            //вывод логотипа компании
            ImageLogo.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath("../../Resources/logoCompany.png")));
        }
        //добавление данных
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (workerComboBox.SelectedItem == null)
                errors.AppendLine("Выберите сотрудника!");
            if (tovarComboBox.SelectedItem == null)
                errors.AppendLine("Выберите товар");
            if (addDatePicker.SelectedDate == null)
                errors.AppendLine("Выберите дату!");
            if (addPricetextBox.SelectedText == null)
                errors.AppendLine("Введите цену!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (addAmounttextBox.SelectedText == null)
                errors.AppendLine("Введите количество!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            //запрос к таблице в которую добавится новая запись
            Entities.GetContext().Buy.Add(new Buy()
            {
                ID_tovar = (tovarComboBox.SelectedItem as Tovar).ID_tovar,
                Amount = addAmounttextBox.Text,
                ID_worker = (workerComboBox.SelectedItem as Worker).ID_worker,
                Date = addDatePicker.SelectedDate.Value,
                Price = addPricetextBox.Text
            });
            Entities.GetContext().SaveChanges();
            ((GlavnoeWindow)this.Owner).UpdateData();
            MessageBox.Show("Данные добавлены!");
            this.Close();
        }







    }
}
