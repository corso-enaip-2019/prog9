using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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

namespace WpfApp02
{
    public partial class MainWindow : Window
    {
        public const string CONNECTION_STRING = @"Server=TRISRV10\SQLEXPRESS;Database=CS2019_Levak_01;Trusted_Connection=True;";

        private MainDbContext _ctx;

        public MainWindow()
        {
            InitializeComponent();

            _ctx = new MainDbContext(CONNECTION_STRING);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadEmployees();
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            var detailWindow = new EmployeeDetailWindow();

            if (detailWindow.ShowDialog() != true)
                return;

            _ctx.Employees.Add(detailWindow.Model);
            _ctx.SaveChanges();

            LoadEmployees();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainGrid.SelectedItem == null)
                return;

            var detailWindow = new EmployeeDetailWindow(MainGrid.SelectedItem as Employee);

            if (detailWindow.ShowDialog() != true)
                return;

            _ctx.SaveChanges();

            LoadEmployees();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainGrid.SelectedItem == null)
                return;

            var deleted = MainGrid.SelectedItem as Employee;

            _ctx.Employees.Remove(deleted);
            _ctx.SaveChanges();

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            MainGrid.ItemsSource = _ctx.Employees.ToList();
        }
    }
}
