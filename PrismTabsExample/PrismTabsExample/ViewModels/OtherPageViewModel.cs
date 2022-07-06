using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTabsExample.ViewModels
{
    public class OtherPageViewModel : ViewModelBase
    {
        public OtherPageViewModel(INavigationService nav) : base(nav)
        {

            Title = "Other Page";
        }
    }
}
