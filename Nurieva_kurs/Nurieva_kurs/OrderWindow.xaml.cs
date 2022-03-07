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
using System.Windows.Shapes;

namespace Nurieva_kurs
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {

            InitializeComponent();

        }

        public OrderWindow(Flower flower)
        {

            InitializeComponent();

            flowerName.Text = flower.name;

            orderButton.Click += (sender, e) =>
            {

                int count;
                if (!int.TryParse(flowerCount.Text, out count)) { MessageBox.Show("Введите число в качестве количества"); return; }
                if (count <= 0) { MessageBox.Show("Количество не может быть меньше или равно 0"); return; }

                if (!new Regex(@"^[0-9]{11}$").IsMatch(flowerPhone.Text)) { MessageBox.Show("Номер телефона должен содержать 11 цифр"); return; }

                if (flowerAddress.Text.Equals("")) { MessageBox.Show("Введите адрес"); return; }

                bdController.AddOrder(flower.id, count, flowerAddress.Text, flowerPhone.Text);

                MessageBox.Show("Заказ успешно оформлен");

                Close();

            };

        }

    }
}