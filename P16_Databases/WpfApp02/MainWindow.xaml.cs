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


        
        public MainWindow()
        {
                InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new MainDbContext(CONNECTION_STRING))
            {
                MainGrid.ItemsSource = ctx.Employees.ToList();
            }
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            var detailWindow = new EmployeeDetailWindow();

            if (detailWindow.ShowDialog() != true)
                return;

            var newEmployee = detailWindow.Model;

            using (var ctx = new MainDbContext(CONNECTION_STRING))
            {
                Debug.WriteLine($"stato di Employee: {ctx.Entry(newEmployee).State}; Id: {newEmployee.Id}");
                ctx.Employees.Add(newEmployee);
                Debug.WriteLine($"stato di Employee: {ctx.Entry(newEmployee).State}; Id: {newEmployee.Id}");
                ctx.SaveChanges();
                Debug.WriteLine($"stato di Employee: {ctx.Entry(newEmployee).State}; Id: {newEmployee.Id}");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainGrid.SelectedItem == null)
                return;

            var detailWindow = new EmployeeDetailWindow(MainGrid.SelectedItem as Employee);

            if (detailWindow.ShowDialog() != true)
                return;

            var updated = detailWindow.Model;

            using (var ctx = new MainDbContext(CONNECTION_STRING))
            {
                Debug.WriteLine($"stato di Employee: {ctx.Entry(updated).State}; Id: {updated.Id}");

                // avendo creato un nuovo DbContext,
                // lui non ha registrato lo stato di updated,
                // quindi devo a mano configurarlo
                // perché consideri 'updated' come un model già creato e modificato:
                ctx.Employees.Attach(updated);
                ctx.Entry(updated).State = EntityState.Modified;

                Debug.WriteLine($"stato di Employee: {ctx.Entry(updated).State}; Id: {updated.Id}");

                ctx.SaveChanges();

                Debug.WriteLine($"stato di Employee: {ctx.Entry(updated).State}; Id: {updated.Id}");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainGrid.SelectedItem == null)
                return;

            var detailWindow = new EmployeeDetailWindow(MainGrid.SelectedItem as Employee);

            var deleted = detailWindow.Model;

            using (var ctx = new MainDbContext(CONNECTION_STRING))
            {
                ctx.Employees.Attach(deleted);
                ctx.Entry(deleted).State = EntityState.Deleted;

                Debug.WriteLine($"stato di Employee: {ctx.Entry(deleted).State}; Id: {deleted.Id}");

                ctx.SaveChanges();

                Debug.WriteLine($"stato di Employee: {ctx.Entry(deleted).State}; Id: {deleted.Id}");


            }

        }
    }
}
