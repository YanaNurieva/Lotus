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

namespace Nurieva_kurs.pages
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {

            InitializeComponent();

            authButton.Click += (s, e) =>
            {

                var emailText = email.Text;
                var passText = pass.Text;

                if (emailText.Equals("") || passText.Equals("")) { MessageBox.Show("Заполните все поля"); return; }

                if (!bdController.auth(emailText, passText)) { MessageBox.Show("Неверный логин или пароль"); return; }
                MessageBox.Show("Авторизация прошла успешно");
                MainWindow.changeFrame(MainWindow.type.itemList);

            };

        }
    }
}
