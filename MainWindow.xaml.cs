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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text;
            string pass = passBox.Password;
            string pass_2 = passBox_2.Password;
            string email = textBoxEmail.Text.Trim().ToLower(); //удалил все пробелы до и после текста и первеел в нижний регистр

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле введено некорректно!"; // добавляет подсказку, когда наводим мышку на объект
                textBoxLogin.Background = Brushes.DarkRed;  // изменяем задний фон подсказки
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Это поле введено некорректно!"; // добавляет подсказку, когда наводим мышку на объект
                passBox.Background = Brushes.DarkRed;  // изменяем задний фон подсказки
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Это поле введено некорректно!"; // добавляет подсказку, когда наводим мышку на объект
                passBox_2.Background = Brushes.DarkRed;  // изменяем задний фон подсказки
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено некорректно!"; // добавляет подсказку, когда наводим мышку на объект
                textBoxEmail.Background = Brushes.DarkRed;  // изменяем задний фон подсказки
            }
            else 
            {
                textBoxLogin.ToolTip = ""; // убираем подсказку
                textBoxLogin.Background = Brushes.Transparent; // ставим прозрачный задний фон подсказки
                passBox.ToolTip = ""; // убираем подсказку
                passBox.Background = Brushes.Transparent; // ставим прозрачный задний фон подсказки
                passBox_2.ToolTip = ""; // убираем подсказку
                passBox_2.Background = Brushes.Transparent; // ставим прозрачный задний фон подсказки
                textBoxEmail.ToolTip = ""; // убираем подсказку
                textBoxEmail.Background = Brushes.Transparent; // ставим прозрачный задний фон подсказки

                MessageBox.Show("Все хорошо!");
            }
        }
    }
}
