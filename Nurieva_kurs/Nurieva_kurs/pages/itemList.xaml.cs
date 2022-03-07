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
    /// Логика взаимодействия для itemList.xaml
    /// </summary>
    public partial class itemList : Page
    {
        public itemList()
        {

            InitializeComponent();

        }

        public void Update()
        {

            list.Children.Clear();

            foreach (var item in bdController.GetFlowers())
            {

                //grid

                var grid = new Grid();

                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());

                var column1 = new ColumnDefinition();
                var column2 = new ColumnDefinition();

                column1.Width = new GridLength(350, GridUnitType.Pixel);

                grid.ColumnDefinitions.Add(column1);
                grid.ColumnDefinitions.Add(column2);

                grid.Margin = new Thickness(15);

                list.Children.Add(grid);

                //img

                var img = new Image();
                var bitImage = new BitmapImage();
                bitImage.BeginInit();
                bitImage.UriSource = new Uri(item.image);
                bitImage.EndInit();
                img.Source = bitImage;
                img.Width = 312;
                img.Height = 312;

                Grid.SetColumn(img, 0);
                Grid.SetRow(img, 0);
                Grid.SetRowSpan(img, 2);

                img.Margin = new Thickness(5);

                grid.Children.Add(img);

                //name

                var text = new TextBlock();
                text.Text = item.name;
                text.HorizontalAlignment = HorizontalAlignment.Center;
                text.VerticalAlignment = VerticalAlignment.Center;
                text.FontSize = 24;
                text.FontFamily = new FontFamily("Century Gothic");
                text.FontWeight = FontWeights.Bold;
                text.TextWrapping = TextWrapping.Wrap;

                Grid.SetColumn(text, 1);
                Grid.SetRow(text, 0);

                grid.Children.Add(text);

                //order button

                var orderButton = new Button();
                orderButton.Content = "Заказать";
                orderButton.HorizontalAlignment = HorizontalAlignment.Center;
                orderButton.VerticalAlignment = VerticalAlignment.Center;
                orderButton.FontSize = 24;
                orderButton.FontFamily = new FontFamily("Century Gothic");
                orderButton.Padding = new Thickness(30, 5, 30, 5);
                orderButton.Background = new SolidColorBrush(Color.FromArgb(255, 187, 152, 111));
                orderButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                orderButton.Margin = new Thickness(0, 0, 0, 15);

                orderButton.Click += (s, e) => new OrderWindow(item).Show();

                Grid.SetColumn(orderButton, 1);
                Grid.SetRow(orderButton, 1);

                grid.Children.Add(orderButton);

            }

        }

    }
}
