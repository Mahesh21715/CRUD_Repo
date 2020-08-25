using CRUD_Demo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CRUD_Demo.ViewModels
{
    public class GetUserViewModel
    {
        public List<User> MyUserList { get; set; }
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public GetUserViewModel()
        {
            var db = new SQLiteConnection(dbPath);
            var user= db.Table<User>().OrderBy(x => x.Name).ToList();
            MyUserList = new List<User>(user);
        }
    }
}
