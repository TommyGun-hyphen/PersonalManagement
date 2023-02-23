using PersonalManagement.Commands;
using PersonalManagement.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonalManagement.ViewModels
{
    public class NavigationMenuItemViewModel : BaseViewModel
    {
        public string Name { get; }
        private BaseViewModel targetViewModel;
        private NavigationStore navigationStore;

        public ICommand NavigateCommand { get; }

        public NavigationMenuItemViewModel(string name, BaseViewModel targetViewModel, NavigationStore navigationStore)
        {
            Name = name;
            this.targetViewModel = targetViewModel;
            this.navigationStore = navigationStore;
            NavigateCommand = new NavigateCommand(navigationStore, targetViewModel);
        }


    }
}
