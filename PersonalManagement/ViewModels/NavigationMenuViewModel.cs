using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalManagement.ViewModels
{
    public class NavigationMenuViewModel : BaseViewModel
    {
        private readonly ObservableCollection<NavigationMenuItemViewModel> menuItems;
        public IEnumerable <NavigationMenuItemViewModel> MenuItems => menuItems;

        public string Title => "test";
        public NavigationMenuViewModel() 
        {
            menuItems = new ObservableCollection<NavigationMenuItemViewModel>();
            menuItems.Add(new NavigationMenuItemViewModel("Home"));
            menuItems.Add(new NavigationMenuItemViewModel("Tasks"));
            menuItems.Add(new NavigationMenuItemViewModel("Notes"));
        }
    }
}
