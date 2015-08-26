using System;
using Myd.Client.App.Services.Authentication;
using Myd.Client.App.Services.Users;
using Xamarin.Forms;

namespace Myd.Client.App.Pages.Login
{
    public partial class LoginPage : ContentPage
    {
        private readonly IAuthenticationService _authService;
        private readonly IUsersService _usersService;
        public LoginModel Model { get; set; }

        public LoginPage(IAuthenticationService authService, IUsersService usersService)
        {
            _authService = authService;
            _usersService = usersService;

            InitializeComponent();

            Model = new LoginModel();

            BindingContext = Model;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await _authService.AuthenticateAsync(new AuthenticationResponseRequest
                {
                    Login = Model.Login,
                    Password = Model.Password
                });
                
                var usersApiResponse = await _usersService.GetUsersAsync(new GetUsersRequest());
            }
            catch (Exception exp)
            {
                await DisplayAlert("Ooooops...", "We are sorry, but looks like that unexpected error happened!", "OK");
            }

        }
    }
}
