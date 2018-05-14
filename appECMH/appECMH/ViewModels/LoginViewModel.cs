
namespace appECMH.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    //class LoginViewModel: INotifyPropertyChanged
    class LoginViewModel : BaseViewModel

    {


       // #region Events
       // public event PropertyChangedEventHandler PropertyChanged;
       // #endregion

        #region Attributes
        private string clave;
        private string usuario;
        private bool isRunning;
        private bool isEnabled;
        

        #endregion

        #region Properties

        public string Usuario
        {
            get { return this.usuario; }
            set { SetValue(ref this.usuario, value); }
        }

        public string Clave
        {

            get { return this.clave; }
            set { SetValue(ref this.clave, value); }
            //get
            //{
            //    return clave;
            //}
            //set
            //{
            //    if(this.clave != value)
            //    {
            //        this.clave = value;
            //        PropertyChanged?.Invoke(
            //            this, new PropertyChangedEventArgs(nameof(this.Clave)));

            //    }
            //}
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }



        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.Usuario = "adriana.diaz";
            this.Clave = "Qumu0378";
            this.IsEnabled = true;

        }
        #endregion


        #region Commands

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);

            }

        }

        

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Necesitas ingresar un usuario.",
                    "Accept");
                return;

            }

            this.isRunning = true;
            this.isEnabled = false;


            if (string.IsNullOrEmpty(this.Clave))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Necesitas ingresar una clave.",
                    "Accept");
                return;

            }


            if (this.Usuario != "adriana.diaz" || this.Clave != "Qumu0378")
            {
                this.isRunning = false;
                this.isEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Usuario o clave incorrectos!!!.",
                    "Accept");
                this.Clave = string.Empty;
                return;
            }

            this.isRunning = false;
            this.isEnabled = true;


            //await Application.Current.MainPage.DisplayAlert(
            //        "OK",
            //        "Login Correcto.",
            //        "Accept");
            //return;s

            this.Usuario = string.Empty;
            this.Clave = string.Empty;

            MainViewModel.GetInstance().Alumno = new AlumnoViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AlumnoPage());


        }




        #endregion


    }
}
