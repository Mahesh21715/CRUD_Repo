using CRUD_Demo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CRUD_Demo.ViewModels
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {

        }
        public Command AddUserPageCommand
        {
            get
            {
                return new Command(AddUserPage);
            }
        }

        public Command DisplayUserPageCommand
        {
            get
            {
                return new Command(DisplayUserPage);
            }
        }
        public Command EditUserPageCommand
        {
            get
            {
                return new Command(EditUserPage);
            }
        }
        public Command DeleteUserPageCommand
        {
            get
            {
                return new Command(DeleteUserPage);
            }
        }

        public void AddUserPage() 
        {
             App.Current.MainPage.Navigation.PushAsync(new AddUserPage());
        }
        public void DisplayUserPage() 
        {
            App.Current.MainPage.Navigation.PushAsync(new GetAllUserPage());
        }
        public void EditUserPage() 
        {
            App.Current.MainPage.Navigation.PushAsync(new EditUserPage());
        }
        public void DeleteUserPage() 
        {
            App.Current.MainPage.Navigation.PushAsync(new DeleteUserPage());
        }
    }
}
