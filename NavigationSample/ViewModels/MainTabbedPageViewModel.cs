using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace NavigationSample.ViewModels
{
    public class MainTabbedPageViewModel : ViewModelBase
    {
        public MainTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}