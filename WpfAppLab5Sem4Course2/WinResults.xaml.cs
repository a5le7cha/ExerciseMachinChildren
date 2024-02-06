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

namespace WpfAppLab5Sem4Course2
{
    /// <summary>
    /// Логика взаимодействия для WinResults.xaml
    /// </summary>
    public partial class WinResults : Window
    {
        public WinResults()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(NumberDelete.Text))
                MessageBox.Show("Введите номер пользователя,\n которого нужно удалить");
            else
            {
                int NumDelUser = int.Parse(NumberDelete.Text);
            }
        }

        private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            AllResultList.Items.Clear();
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < WinUser.listStudents.Count; i++)
            {
                AllResultList.Items.Add(Convert.ToString(Convert.ToString(i) + "." + " " + WinUser.listStudents[i].ToString()));
            }
        }

        private void BackMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
