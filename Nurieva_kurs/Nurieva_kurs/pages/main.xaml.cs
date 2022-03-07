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
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Page
    {
        public main()
        {

            InitializeComponent();

            regButton.Click += (s, e) => MainWindow.changeFrame(MainWindow.type.reg);

            authButton.Click += (s, e) => MainWindow.changeFrame(MainWindow.type.auth);

        }
    }
}
