using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Page
    {
        public reg()
        {

            InitializeComponent();

            regButton.Click += (s, e) =>
            {

                var emailText = email.Text;
                var passText = pass.Text;
                var passRepText = passRep.Text;

                if (emailText.Length <= 6 || passText.Length <= 6) { MessageBox.Show("Заполните все поля\nЕ-майл и пароль должны быть длинее 6 символов"); return; }
                if (!passText.Equals(passRepText)) { MessageBox.Show("Пароли не совпадают"); return; }

                if (!new Regex(@"^.*@.*\..*$").IsMatch(emailText)) { MessageBox.Show("Е-майл не соответсвует паттерну *@*.*"); return; }

                if (!bdController.reg(emailText, passText)) { MessageBox.Show("Данный е-майл уже используется"); return; }

                MessageBox.Show("Регистрация прошла успешно");
                MainWindow.changeFrame(MainWindow.type.choice);

            };

        }
    }
}
