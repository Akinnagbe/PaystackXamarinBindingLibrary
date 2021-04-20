using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class SampleView : ContentPage
    {
        public SampleView()
        {
            InitializeComponent();
        }

        protected void Pay(object sender,EventArgs e)
        {
            DependencyService.Get<IPaystackService>().TestPayment();
        }
    }
}
