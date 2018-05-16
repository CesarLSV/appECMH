
namespace appECMH.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;
    using ViewModels;
    using System;

    class AlumnoViewModel :BaseViewModel
     {

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

        #endregion
    }
}
