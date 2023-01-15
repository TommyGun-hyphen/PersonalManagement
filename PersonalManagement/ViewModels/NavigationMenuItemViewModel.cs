using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.ViewModels
{
    public class NavigationMenuItemViewModel : BaseViewModel
    {
        public string Name { get; }

        public NavigationMenuItemViewModel(string name)        {
            Name = name;
        }

    }
}
