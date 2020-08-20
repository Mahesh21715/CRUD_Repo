using CRUD_Demo.Models;
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
    public partial class GetAllUserPage : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        public GetAllUserPage()
        {
            InitializeComponent();
           // BindingContext = new GetAllUserPage();
            var db = new SQLiteConnection(dbPath);
            UsersListView.ItemsSource = db.Table<User>().OrderBy(x => x.Name).ToList();
        }
    }
}