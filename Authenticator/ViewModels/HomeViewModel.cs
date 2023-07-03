using Authenticator.Models;
using Authenticator.Views.Home;
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
        private List<AccountModel> _accountsData;

        [ObservableProperty]
        private AccountModel _selctedAccount;



        [RelayCommand]
        private void GetInitialData()
        {
            AccountsData = new List<AccountModel>
            {
                new AccountModel()
                {
                    Id = 1,
                    Email = "email1@gmail.com",
                    OrganizationName = "Organization 1"
                },
                new AccountModel()
                {
                    Id = 2,
                    Email = "email2@gmail.com",
                    OrganizationName = "Organization 2"
                },
                new AccountModel()
                {
                    Id = 3,
                    Email = "email3@gmail.com",
                    OrganizationName = "Organization 3"
                },
                new AccountModel()
                {
                    Id = 4,
                    Email = "email4@gmail.com",
                    OrganizationName = "Organization 4"
                },
            };
        }


        [RelayCommand]
        private async Task ViewAccountDetails(AccountModel selectedAccount)
        {
            await Shell.Current.GoToAsync($"{nameof(AccountDetailsPage)}?accountIdParam={selectedAccount.Id}");
        }

    }
}
