using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiprimeraApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void btn_uno(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Navegacion());
        }
    }
}
