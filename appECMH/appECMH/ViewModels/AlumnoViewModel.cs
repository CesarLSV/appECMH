
namespace appECMH.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    using System;
    using Services;
    using System.Collections.ObjectModel;
    using System.Collections.Generic;
    using appECMH.Models;

   public class AlumnoViewModel :BaseViewModel
     {

        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
      //  private ObservableCollection<LoggedUser> loggedUser;
        
        private ObservableCollection<LoggedUser> loggedUser;
        private List<LoggedUser> ListaLoggedUser;
        #endregion

        #region Properties
        public ObservableCollection<LoggedUser> LoggedUser
        {
            get { return this.loggedUser; }
            set { SetValue(ref this.loggedUser, value); }
        }


        #endregion



        #region Command

        public ICommand NotasCommand
        {
            get
            {
                return new RelayCommand(Notas);

            }

        }

        private async void Notas()
        {
           
            MainViewModel.GetInstance().Notas = new NotasViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new NotasPage());


        }


        public ICommand BibliotecaCommand
        {
            get
            {

                return new RelayCommand(Biblioteca);

             }
            
        }

        private async void Biblioteca()
        {
            MainViewModel.GetInstance().Biblioteca = new BibliotecaViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new BibliotecaPage());
        }



        public ICommand HorariosCommand
        {
            get
            {

                return new RelayCommand(Horarios);

            }

        }

        private async void Horarios()
        {
            MainViewModel.GetInstance().Horarios = new HorariosViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new HorariosPage());
        }

        #endregion


        #region Constructors
        public AlumnoViewModel()
        {
            this.apiService = new ApiService();
            this.LoadUserLogged();

        }

        #endregion



        #region Methods
        private async void LoadUserLogged()
        {
           // this.IsRefreshing = true;
            var conection = await this.apiService.CheckConnection();

            if (!conection.IsSuccess)
            {
                //this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    conection.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            var response = await this.apiService.GetList<LoggedUser>(
                "https://sigecmh.monicaherrera.edu.sv/apiECMH/",
                "api/data",
                "/authenticate",
                "bearer",
                MainViewModel.GetInstance().Token.AccessToken);

            if (!response.IsSuccess)
            {
                //this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            this.ListaLoggedUser = (List<LoggedUser>)response.Result;
            this.LoggedUser = new ObservableCollection<LoggedUser>(this.ListaLoggedUser);
            //this.IsRefreshing = false;

            //this.Notas = new ObservableCollection<Notas>(this.NotasLista);
            //this.IsRefreshing = false;
        }
        #endregion


    }
}
