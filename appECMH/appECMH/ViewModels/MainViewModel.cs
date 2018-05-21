namespace appECMH.ViewModels
{
    using Models;

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

        public NotasViewModel Notas
        {
            get;
            set;
        }

        public DetalleMateriaViewModel DetalleMateria
        {
            get;
            set;
        }

        public BibliotecaViewModel Biblioteca
        {
            get;
            set;
        }


        public HorariosViewModel Horarios
        {
            get;
            set;
        }

        #endregion


        #region Properties
        public TokenResponse Token
        {
            get;
            set;
        }

        public TokenResponse UserLog
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
