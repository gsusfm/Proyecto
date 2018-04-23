using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnalisisT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Iphone8 : ContentPage
    {
        public Iphone8()
        {
            InitializeComponent();
        }
        private void Volver(Object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new MainTabbed());
        }
    }
}