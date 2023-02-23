using PersonalManagement.Stores;
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
        private NavigationStore navigationStore;
        private TodoStore todoStore;
        public App()
        {
            todoStore = new TodoStore();
            navigationStore = new NavigationStore(new TodoListViewModel(todoStore));
            navigationMenuViewModel = new NavigationMenuViewModel(navigationStore, todoStore);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.DataContext = new MainViewModel(navigationMenuViewModel, navigationStore);
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
