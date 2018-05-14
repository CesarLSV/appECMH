﻿namespace appECMH.ViewModels
{
    
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        
        public AlumnoViewModel Alumno
        {
            get;
            set;
        }
        #endregion


        #region Constructor

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }


        #endregion


        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();

            }
            return instance;
        }

        #endregion

    }
}