using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp02
{
    public partial class EmployeeDetailWindow : Window
    {
        public EmployeeDetailWindow(Employee model = null)
        {
            InitializeComponent();

            Model = model ?? new Employee();

            NameTextBox.Text = Model.Name;
            ProductivityTextBox.Text = Model.Productivity.ToString();
            TotalBonusTextBox.Text = Model.TotalBonus.ToString();
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Model.Name = NameTextBox.Text;
            Model.Productivity = double.Parse(ProductivityTextBox.Text, CultureInfo.InvariantCulture);
            Model.TotalBonus = int.Parse(TotalBonusTextBox.Text, CultureInfo.InvariantCulture);

            DialogResult = true;
        }

        public Employee Model { get; set; }
    }
}
