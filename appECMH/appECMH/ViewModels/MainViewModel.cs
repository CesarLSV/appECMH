namespace appECMH.ViewModels
{
    
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion


        #region Constructor

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }


        #endregion

    }
}
