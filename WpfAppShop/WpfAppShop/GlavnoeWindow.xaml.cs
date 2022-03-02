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
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;

namespace WpfAppShop
{
    /// <summary>
    /// Логика взаимодействия для GlavnoeWindow.xaml
    /// </summary>
    public partial class GlavnoeWindow : Window
    {
        private Worker worker;
        public GlavnoeWindow(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            family_label.Content = worker.SecondName;
            name_label.Content = worker.FirstName;
            //вывод логотипа компании
            ImageLogo.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath("../../Resources/logoCompany.png")));
            //вывод картинки профиля
            ImageProfile.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath("../../Resources/ImageProfile.png")));
            // Работа фильтра
            InitCategoryCB();

            // Обновление данных
            UpdateData();
        }
        public void UpdateData()
        {
            //формирование запроса и вывод данных из базы данных
            Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var join_massive = from buy in Entities.GetContext().Buy
                               join tovar in Entities.GetContext().Tovar on buy.ID_tovar equals tovar.ID_tovar
                               join rabotnik in Entities.GetContext().Worker on buy.ID_worker equals rabotnik.ID_worker
                               join category in Entities.GetContext().Category on tovar.Category equals category.ID_category                
                               select new
                               {
                                   ID_buy = buy.ID_buy,
                                   ID_category = category.ID_category,
                                   nameCategory = category.Name_category,
                                   ID_tovar = buy.ID_tovar.ToString() + " " + tovar.Name,
                                   Amount = buy.Amount,
                                   ID_worker = buy.ID_worker.ToString() + " " + rabotnik.FirstName + " " + rabotnik.SecondName,
                                   Price = buy.Price,
                                   Date = buy.Date
                               };
            //работа фильтра
            if (filterCategory.SelectedIndex > 0)
                join_massive = join_massive.Where(item => item.ID_category == filterCategory.SelectedIndex);
            //работа поиска
            if (!String.IsNullOrEmpty(SearchBox.Text.Trim()))
                join_massive = join_massive.Where(item => item.ID_tovar.Contains(SearchBox.Text.Trim()));
            //работа сортировки
            if ((bool)sortBox.IsChecked)
                join_massive = join_massive.OrderByDescending(item => item.Price);
            //строка вывода данных
            dataGridbuy.ItemsSource = join_massive.ToList();

        }
        //метод для работы фильтра
        private void InitCategoryCB()
        {
            filterCategory.Items.Add(" ничего ");
            filterCategory.SelectedIndex = 0;

            var data = from category in Entities.GetContext().Category
                       select category;

            data.ToList().ForEach((Category category) =>
            {
                filterCategory.Items.Add(category.Name_category);
            });
        }

        //закрытие главного окна
        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //закрытие проекта
        private void Windows_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        //удаление записи из базы данных
        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Удалить выбранную запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                int id = (int)TypeDescriptor.GetProperties(dataGridbuy.SelectedItem)[0].GetValue(dataGridbuy.SelectedItem);
                Buy buy = Entities.GetContext().Buy.Where(p => p.ID_buy == id).First();
                Entities.GetContext().Buy.Remove(buy);
                Entities.GetContext().SaveChanges();
                UpdateData();
            }
        }
        //неактивность кнопки "Удаление" до выбора записи
        private void dataGridbuy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteButton.IsEnabled = true;
        }

        //редактирование записи
        private void Edin_button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            EditBuyWindow editBuyWindow = new EditBuyWindow(Entities.GetContext().Buy.Where(p => p.ID_buy == (int)button.Tag).First());
            editBuyWindow.Owner = this;
            editBuyWindow.Show();
        }

        //добавление новой записи
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            AddBuyWindow addBuy = new AddBuyWindow(worker);
            addBuy.Owner = this;
            addBuy.Show();
        }

        //открытие окна с диаграммой
        private void Diagramma_button_Click(object sender, RoutedEventArgs e)
        {
            DiagrammaWindow dio = new DiagrammaWindow();
            dio.Show();
        }

        //поиск по названию товара
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        //фильт по категориям
        private void filterCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
        //сортировка по цене
        private void sortBox_Checked(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }
    }
}
