using FlexLayoutDemo.Pages;

namespace FlexLayoutDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlexLayoutPage();
        }
    }
}