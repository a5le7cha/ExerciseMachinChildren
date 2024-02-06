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
    /// Логика взаимодействия для WinUser.xaml
    /// </summary>
    /// 
    public partial class WinUser : Window
    {
        public static List<Student> listStudents = new List<Student>(); //список участников тренажера

        public WinUser()
        {
            InitializeComponent();
        }

        private void btnUserOK_Click(object sender, RoutedEventArgs e)
        {
            Student std = new Student();

            std.fio = FIO.Text;
            std.Class = Class.Text;
            listStudents.Add(std);
            Close();
        }
    }
}
