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
    public partial class EditUserPage : ContentPage
    {
        //User user = new User();
        //string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public EditUserPage()
        {
            InitializeComponent();
            BindingContext = new EditUserViewModel();
            //UserListView.ItemsSource = db.Table<User>().OrderBy(x => x.Name).ToList();
        }

        public void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = e.Item as User;
            Id.Text = Convert.ToString(data.Id);
            UserName.Text = data.Name;
            UserAddress.Text = data.Address;
        }

        //private async  void UpdateUser_Clicked(object sender, EventArgs e)
        //{
        //    var db = new SQLiteConnection(dbPath);
        //    User user = new User()
        //    {
        //        Id = Convert.ToInt32(Id.Text),
        //        Name = UserName.Text,
        //        Address = UserAddress.Text
        //    };
        //    db.Update(user);
        //    await DisplayAlert(null, "user "+user.Id + " Uppdates", "Ok");
        //    await Navigation.PopAsync();
        //}

        //private void UserListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    user = (User)e.SelectedItem;
        //    Id.Text = user.Id.ToString();
        //    UserName.Text = user.Name;
        //    UserAddress.Text = user.Address;
        //}
    }
}