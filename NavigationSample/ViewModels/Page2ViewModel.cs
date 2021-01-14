using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace NavigationSample.ViewModels
{
    public class Page2ViewModel : ViewModelBase
    {
        public Page2ViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}