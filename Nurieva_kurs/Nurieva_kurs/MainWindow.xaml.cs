using Nurieva_kurs.pages;
using System.Windows;
using System.Windows.Controls;

namespace Nurieva_kurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static Frame staticFrame;

        static main mainPage = new main();
        static auth authPage = new auth();
        static reg regPage = new reg();
        static choice choicePage = new choice();
        static itemList itemListPage = new itemList();

        public MainWindow()
        {
            InitializeComponent();

            staticFrame = mainFrame;
            changeFrame(type.main);

        }

        public static void changeFrame(type type)
        {

            switch (type)
            {

                case type.main: staticFrame.Navigate(mainPage); break;

                case type.auth: staticFrame.Navigate(authPage); break;

                case type.reg: staticFrame.Navigate(regPage); break;

                case type.choice: staticFrame.Navigate(choicePage); break;

                case type.itemList: itemListPage.Update(); staticFrame.Navigate(itemListPage); break;

            }

        }

        public enum type
        {

            main,
            auth,
            reg,
            choice,
            itemList

        }

    }
}
