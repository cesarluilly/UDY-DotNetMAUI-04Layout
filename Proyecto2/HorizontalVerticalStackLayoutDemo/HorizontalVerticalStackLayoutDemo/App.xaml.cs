using HorizontalVerticalStackLayoutDemo.Pages;

namespace HorizontalVerticalStackLayoutDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new VerticalStackLayoutDemo();
            MainPage = new HorizontalStackLayoutDemo();
        }
    }
}