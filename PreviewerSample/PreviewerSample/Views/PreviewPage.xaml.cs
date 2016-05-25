using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PreviewerSample.Views
{
    public partial class PreviewPage : ContentPage
    {
        public PreviewPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.PersonsViewModel();
        }
    }
}

