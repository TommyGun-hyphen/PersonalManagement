using PersonalManagement.Stores;
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
        private readonly NavigationStore navigationStore;
        private readonly TodoStore todoStore;

        public IEnumerable <NavigationMenuItemViewModel> MenuItems => menuItems;

        public string Title => "test";
        public NavigationMenuViewModel(NavigationStore navigationStore, TodoStore todoStore) 
        {
            menuItems = new ObservableCollection<NavigationMenuItemViewModel>();
            this.navigationStore = navigationStore;
            this.todoStore = todoStore;

            menuItems.Add(new NavigationMenuItemViewModel("Todos", new TodoListViewModel(todoStore), navigationStore));

        }
    }
}
