using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Button_Tutorial
{
    public partial class MainPage : ContentPage
    {
        void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click me again!";
        }
    }
}
