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
    public class AddUserViewModel : INotifyPropertyChanged
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
        
        public event PropertyChangedEventHandler PropertyChanged;

        public AddUserViewModel()
        {  }

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

       


        public Command AddCommand
        {
            get
            {
                return new Command(SaveUser);
            }
        }
        public void SaveUser()
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<User>();

            //var maxPk = db.Table<User>().OrderByDescending(c => c.Id).FirstOrDefault();

            User user = new User()
            {
                Id = id,
                Name = name,
                Address = addr
            };
            db.Insert(user);

            App.Current.MainPage.DisplayAlert(null, "User Id : "+id+ " Saved In Database", "Ok");
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}

