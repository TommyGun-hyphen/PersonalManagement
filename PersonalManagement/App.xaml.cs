using PersonalManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NavigationMenuViewModel navigationMenuViewModel;

        public App()
        {
            navigationMenuViewModel = new NavigationMenuViewModel();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.DataContext = new MainViewModel(navigationMenuViewModel);
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
