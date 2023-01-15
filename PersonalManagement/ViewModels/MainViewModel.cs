using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public NavigationMenuViewModel NavigationMenuViewModel { get; }

        public MainViewModel(NavigationMenuViewModel navigationMenuViewModel)
        {
            this.NavigationMenuViewModel = navigationMenuViewModel;
        }
    }
}
