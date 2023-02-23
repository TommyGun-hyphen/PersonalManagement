using PersonalManagement.Stores;
using PersonalManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.Commands
{
    internal class NavigateCommand : BaseCommand
    {
        private readonly NavigationStore navigationStore;
        private BaseViewModel targetViewModel;
        public override void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = targetViewModel;
        }

        public NavigateCommand(NavigationStore navigationStore, BaseViewModel targetViewModel)
        {
            this.navigationStore = navigationStore;
            this.targetViewModel = targetViewModel;
        }
    }
}
