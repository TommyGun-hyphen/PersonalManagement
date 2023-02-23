using PersonalManagement.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore navigationStore;

        public NavigationMenuViewModel NavigationMenuViewModel { get; }
        public BaseViewModel CurrentViewModel => navigationStore.CurrentViewModel;

        public MainViewModel(NavigationMenuViewModel navigationMenuViewModel, NavigationStore navigationStore)
        {
            this.NavigationMenuViewModel = navigationMenuViewModel;
            this.navigationStore = navigationStore;
        }
    }
}
