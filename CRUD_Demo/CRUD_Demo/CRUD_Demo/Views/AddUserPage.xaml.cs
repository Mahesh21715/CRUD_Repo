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
    public partial class AddUserPage : ContentPage
    {

        //string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"myDB.db3");
        public AddUserPage()
        {
            InitializeComponent();
            BindingContext = new AddUserViewModel();
        }

    //    private async void SaveUser(object sender, EventArgs e)
    //    {
    //        var db = new SQLiteConnection(dbPath);

    //        db.CreateTable<User>();

    //        var maxPk = db.Table<User>().OrderByDescending(c => c.Id).FirstOrDefault();

    //        User user = new User()
    //        {
    //            Id = (maxPk == null ? 1 : maxPk.Id + 1),
    //            Name = UserName.Text,
    //            Address = UserAddress.Text
    //        };
    //        db.Insert(user);

    //        await DisplayAlert(null, user.Name + "Saved","Ok");
    //        await Navigation.PopAsync();
    //    }
}
}