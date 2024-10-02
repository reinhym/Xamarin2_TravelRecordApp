using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin2_TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage : TabbedPage
    {
        public NavigationPage()
        {
            InitializeComponent();
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}