using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using V2.Model;
using V2.ViewModel;

namespace V2
{
    public partial class MainWindow : Window
    {
        List<string> ListStr = new List<string>()
        {
            "qwe_1","qwe_2","qwe_3","qwe_4","qwe_5"
        };
        List<User> user = new List<User>()
        {
            new User(0,"name_0","qwe@mail.ru"),
            new User(1,"name_1","qwe@mail.ru"),
            new User(2,"name_2","qwe@mail.ru"),
            new User(3,"name_3","qwe@mail.ru"),
        };
        public MainWindow()
        {
            InitializeComponent();

            MyListBox.ItemsSource = ListStr;
            MyListView.ItemsSource = user;
            MyDataGrid.ItemsSource = user;

        }
        public void Num(object obj, RoutedEventArgs e)
        {
            ErrorBox.ErrorMes("всё плохааааа");
        }
        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? num = MyListBox.SelectedItem.ToString();

            MessageBox.Show(num);
        }
        private void MyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User? value = MyListView.SelectedItem as User;

            TextId.Text = value!.Id.ToString();
            TextName.Text = value.Name;
            TextEmail.Text = value.Email;
        }
        private void addItemInList(object sender, RoutedEventArgs e)
        {
            User value = new User(Convert.ToInt32(InputTextId.Text), InputTextName.Text, InputTextEmail.Text);
            user.Add(value);
            MyListView.Items.Refresh();
        }
    }   
}
