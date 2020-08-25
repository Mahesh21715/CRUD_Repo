using CRUD_Demo.Models;
using CRUD_Demo.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUD_Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeleteUserPage : ContentPage
    {
        User user = new User();
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public DeleteUserPage()
        {
            var db = new SQLiteConnection(dbPath);
            InitializeComponent();
            //BindingContext = new DeleteUserViewModel();
            
            UserListView.ItemsSource = db.Table<User>().OrderBy(x => x.Name).ToList();
        }

        private async void DeleteUser_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);
            db.Table<User>().Delete(x => x.Id == user.Id);
            await DisplayAlert(null, user.Name + " Deleted", "Ok");
            await Navigation.PopAsync();
        }

        private void UserListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            user = (User)e.SelectedItem;
        }
    }
}