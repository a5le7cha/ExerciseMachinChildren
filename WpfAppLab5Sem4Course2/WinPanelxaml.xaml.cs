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

namespace WpfAppLab5Sem4Course2
{
    /// <summary>
    /// Логика взаимодействия для WinPanelxaml.xaml
    /// </summary>
    public partial class WinPanelxaml : Window
    {
        const int size = 5;
        bool[,] PanBtnBool = new bool[size-1, size];
        int CountClickBtn = 0;

        public List<string[]>[] listQuetion = new List<string[]>[size];

        public WinPanelxaml()
        {
            InitializeComponent();

            using (var sr = new StreamReader("Quetions.txt")) //Списывание вопросов
            {
                for (int i = 0; i < size; i++)
                {
                    listQuetion[i].Add(sr.ReadLine().Split(new char[] {';'}, 
                        StringSplitOptions.RemoveEmptyEntries));
                }
            }

            for (int i = 0; i < size-1; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var btn = new Button();
                    btn.SetValue(Grid.ColumnProperty, j);
                    btn.SetValue(Grid.RowProperty, i);
                    btn.Background = new SolidColorBrush(Colors.Azure);
                    btn.Click += ButtonClick;
                    btn.Name = "btn" + (i+1)  * 10 + (j+1);
                    btn.Content = (j+1) * 10;
                    PanelButton.Children.Add(btn);
                    PanBtnBool[i, j] = false;
                }
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            CountClickBtn++;
            var btn = (Button)sender;
            var i = (int)btn.GetValue(Grid.RowProperty);
            var j = (int)btn.GetValue(Grid.ColumnProperty);

            if (!PanBtnBool[i, j])
            {
                WinClickBtn win = new WinClickBtn();
                win.ShowDialog();
                WinUser.listStudents[0].SumMark((int)btn.Content);
                btn.Background = new SolidColorBrush(Colors.Gray);
                PanBtnBool[i, j] = true;
            }

            if (CountClickBtn == 25)
            {
                MessageBox.Show("Вы ответели на все вопросы");
                Close();
            }
                
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
