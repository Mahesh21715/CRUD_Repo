using CRUD_Demo.Models;
using CRUD_Demo.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace CRUD_Demo.ViewModels
{
    public class EditUserViewModel: INotifyPropertyChanged
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public List<User> MyUserList { get; set; }

        User user = new User();
        public event PropertyChangedEventHandler PropertyChanged;
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private string addr;
        public string Address
        {
            get { return addr; }
            set
            {
                addr = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }
        }

        public User _selectedUser { get; set;}
        public User SelectedUser
        {
            get { return _selectedUser; }

            set
            {
                if(_selectedUser!=value)
                {
                    _selectedUser = value;

                   // ViewUser();
                }
            }

        }
        public EditUserViewModel()
        {
            var db = new SQLiteConnection(dbPath);
            var user = db.Table<User>().OrderBy(x => x.Name).ToList();
            MyUserList = new List<User>(user);
        }

        public Command EditCommand
        {
            get
            {
                return new Command(EditUser);
            }
        }

        public void EditUser()
        {
            var db = new SQLiteConnection(dbPath);
            User user = new User()
            {
               Id = Id,
               Name = Name,
               Address = Address
            };
            db.Update(user);
            App.Current.MainPage.DisplayAlert(null, "User Id : " + id + " Updated", "Ok");
            App.Current.MainPage.Navigation.PopAsync();
        }        
    }
}
