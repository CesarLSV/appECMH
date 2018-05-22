
namespace appECMH.ViewModels
{
    using appECMH.Helpers;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;

    class MenuItemViewModel
    {
        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; } 
        #endregion


        #region Commands

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
            
        }

        private void Navigate()
        {
           if (this.PageName == "LoginPage")
            {

                Settings.Token = string.Empty;
                Settings.TokenType = string.Empty;

                MainViewModel.GetInstance().Token = string.Empty;
                MainViewModel.GetInstance().Token = string.Empty;

                /* Application.Current.MainPage = new LoginPage();*/
                 Application.Current.MainPage = new NavigationPage(new LoginPage());

            }


            if (this.PageName == "NotasPage")
            {

               /* Application.Current.MainPage = new LoginPage();*/
               Application.Current.MainPage = new NavigationPage(new NotasPage());

            }



        }
        #endregion
    }
}

