using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab13.DataContext;
using Lab13.Views;
using Lab13.Interfaces;

namespace Lab13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetContext().Database.EnsureCreated();
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new Views.MainPage());
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
