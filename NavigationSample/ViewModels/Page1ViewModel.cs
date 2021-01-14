using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace NavigationSample.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {
        public Page1ViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}