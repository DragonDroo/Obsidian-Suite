﻿using System;
using System.Windows.Input;

using Microsoft.Extensions.Options;

using Slats.Contracts.Services;
using Slats.Contracts.ViewModels;
using Slats.Core.Contracts.Services;
using Slats.Core.Helpers;
using Slats.Helpers;
using Slats.Models;

namespace Slats.ViewModels
{
    // TODO WTS: Change the URL for your privacy policy in the appsettings.json file, currently set to https://YourPrivacyUrlGoesHere
    public class SettingsViewModel : Observable, INavigationAware
    {
        private readonly AppConfig _appConfig;
        private readonly IUserDataService _userDataService;
        private readonly IIdentityService _identityService;
        private readonly IThemeSelectorService _themeSelectorService;
        private readonly ISystemService _systemService;
        private readonly IApplicationInfoService _applicationInfoService;
        private AppTheme _theme;
        private string _versionDescription;
        private bool _isBusy;
        private bool _isLoggedIn;
        private UserViewModel _user;
        private ICommand _setThemeCommand;
        private ICommand _privacyStatementCommand;
        private RelayCommand _logInCommand;
        private RelayCommand _logOutCommand;

        public AppTheme Theme
        {
            get { return _theme; }
            set { Set(ref _theme, value); }
        }

        public string VersionDescription
        {
            get { return _versionDescription; }
            set { Set(ref _versionDescription, value); }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                Set(ref _isBusy, value);
                LogInCommand.OnCanExecuteChanged();
                LogOutCommand.OnCanExecuteChanged();
            }
        }       

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { Set(ref _isLoggedIn, value); }
        }

        public UserViewModel User
        {
            get { return _user; }
            set { Set(ref _user, value); }
        }

        public ICommand SetThemeCommand => _setThemeCommand ?? (_setThemeCommand = new RelayCommand<string>(OnSetTheme));

        public ICommand PrivacyStatementCommand => _privacyStatementCommand ?? (_privacyStatementCommand = new RelayCommand(OnPrivacyStatement));

        public RelayCommand LogInCommand => _logInCommand ?? (_logInCommand = new RelayCommand(OnLogIn, () => !IsBusy));

        public RelayCommand LogOutCommand => _logOutCommand ?? (_logOutCommand = new RelayCommand(OnLogOut, () => !IsBusy));

        public SettingsViewModel(IOptions<AppConfig> appConfig, IThemeSelectorService themeSelectorService, ISystemService systemService, IApplicationInfoService applicationInfoService, IUserDataService userDataService, IIdentityService identityService)
        {
            _appConfig = appConfig.Value;
            _themeSelectorService = themeSelectorService;
            _systemService = systemService;
            _applicationInfoService = applicationInfoService;
            _userDataService = userDataService;
            _identityService = identityService;
        }

        public void OnNavigatedTo(object parameter)
        {
            VersionDescription = $"Slats - {_applicationInfoService.GetVersion()}";
            Theme = _themeSelectorService.GetCurrentTheme();
            _identityService.LoggedIn += OnLoggedIn;
            _identityService.LoggedOut += OnLoggedOut;
            IsLoggedIn = _identityService.IsLoggedIn();
            _userDataService.UserDataUpdated += OnUserDataUpdated;
            User = _userDataService.GetUser();
        }

        public void OnNavigatedFrom()
        {
            UnregisterEvents();
        }

        private void UnregisterEvents()
        {
            _identityService.LoggedIn -= OnLoggedIn;
            _identityService.LoggedOut -= OnLoggedOut;
            _userDataService.UserDataUpdated -= OnUserDataUpdated;
        }

        private void OnSetTheme(string themeName)
        {
            var theme = (AppTheme)Enum.Parse(typeof(AppTheme), themeName);
            _themeSelectorService.SetTheme(theme);
        }

        private void OnPrivacyStatement()
            => _systemService.OpenInWebBrowser(_appConfig.PrivacyStatement);

        private async void OnLogIn()
        {
            IsBusy = true;
            var loginResult = await _identityService.LoginAsync();
            if (loginResult != LoginResultType.Success)
            {
                await AuthenticationHelper.ShowLoginErrorAsync(loginResult);
                IsBusy = false;
            }
        }

        private async void OnLogOut()
        {
            await _identityService.LogoutAsync();
        }

        private void OnUserDataUpdated(object sender, UserViewModel userData)
        {
            User = userData;
        }

        private void OnLoggedIn(object sender, EventArgs e)
        {
            IsLoggedIn = true;
            IsBusy = false;
        }

        private void OnLoggedOut(object sender, EventArgs e)
        {
            User = null;
            IsLoggedIn = false;
            IsBusy = false;
        }
    }
}
