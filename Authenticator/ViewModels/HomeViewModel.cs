using Authenticator.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticator.ViewModels
{
    public partial class HomeViewModel:ObservableObject
    {
        [ObservableProperty]
        private List<PasswordModel> _accountsData;



        [RelayCommand]
        private async Task GetInitialData()
        {
            AccountsData = new List<PasswordModel>
            {
                new PasswordModel()
                {
                    Id = 1,
                    Email = "email1@gmail.com",
                    OrganizationName = "Organization 1"
                },
                new PasswordModel()
                {
                    Id = 2,
                    Email = "email2@gmail.com",
                    OrganizationName = "Organization 2"
                },
                new PasswordModel()
                {
                    Id = 3,
                    Email = "email3@gmail.com",
                    OrganizationName = "Organization 3"
                },
                new PasswordModel()
                {
                    Id = 4,
                    Email = "email4@gmail.com",
                    OrganizationName = "Organization 4"
                },
            };
        }

    }
}
