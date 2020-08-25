using CRUD_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUD_Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }

        //private async void AddUser(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AddUserPage());
        //}

        //private async void GetUser(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new GetAllUserPage());
        //}

        //private async void EditUser(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new EditUserPage());
        //}

        //private async void DeleteUser(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new DeleteUserPage());
        //}

    }
}