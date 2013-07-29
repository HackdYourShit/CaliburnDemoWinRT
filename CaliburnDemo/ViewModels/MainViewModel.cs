﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Caliburn.Micro.Unity.WinRT.ViewModels;
using PropertyChanged;
using Windows.UI.Popups;

namespace CaliburnDemo.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel: ViewModelBase
    {
        public string Title { get; set; }

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Caliburn Demo";
        }

        public void GoToSecondPage()
        {
            var md = new MessageDialog("GoToSecondPage invoked", "SecondPageViewModel");
            md.ShowAsync();
        }
    }
}
