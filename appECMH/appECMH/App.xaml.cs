﻿



namespace appECMH
{
    using Views;
    using Xamarin.Forms;
    using Helpers;
    using ViewModels;

    public partial class App : Application
	{

        #region Properties
        public static NavigationPage Navigator
        {
            get;
            internal set;
        }

        public static MasterPage Master
        {
            get;
            internal set;
        }

        #endregion

        #region Constructors


        public App ()
		{
			InitializeComponent();

           // MainPage = new MasterPage();
           // MainPage = new NavigationPage(new LoginPage());
           if (string.IsNullOrEmpty(Settings.Token))

            {
                this.MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                var mainViewModel = MainViewModel.GetInstance();

                mainViewModel.Token = Settings.Token;
                mainViewModel.TokenType = Settings.TokenType;

                MainViewModel.GetInstance().Alumno = new AlumnoViewModel();
                this.MainPage = new MasterPage();

            }


        }

        #endregion



        #region Methods

        
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        #endregion

    }
}
