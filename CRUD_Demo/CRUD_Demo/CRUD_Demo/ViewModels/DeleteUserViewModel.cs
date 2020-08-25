using CRUD_Demo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace CRUD_Demo.ViewModels
{
    public class DeleteUserViewModel : INotifyPropertyChanged
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public List<User> MyUserList { get; set; }
        
        public DeleteUserViewModel()
        {
            var db = new SQLiteConnection(dbPath);
            var user = db.Table<User>().OrderBy(x => x.Name).ToList();
            MyUserList = new List<User>(user);
        }
        private void OnTapped(object obj)
        {
            var un = obj as User;
            MyUserList.Remove(un);
            App.Current.MainPage.DisplayAlert("Message", "Item Deleted :" + un.Name, "Ok");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Command DeleteCommand
        {
            get
            {
                return new Command(DeleteUser);
            }
        }

        public void DeleteUser()
        {
         
        }
    }
}
