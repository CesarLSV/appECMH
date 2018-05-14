﻿namespace appECMH.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Services;
    using Xamarin.Forms;

    class AlumnoViewModel :BaseViewModel
     {

        #region Services
        private ApiService apiService;
        #endregion


        #region Attributes
        private ObservableCollection<Notas> notasx;

        #endregion


        #region Properties
        public ObservableCollection<Notas> Notasx
        {
            get { return this.notasx; }
            set { SetValue(ref this.notasx, value); }
        }
        #endregion

        #region Constructors
        public AlumnoViewModel()
        {
            this.apiService = new ApiService();
            this.LoadNotas();

        }

        #endregion

        #region Methods
        private async void LoadNotas()
        {

            var conection = await this.apiService.CheckConnection();

            if (!conection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    conection.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            var response = await this.apiService.GetList<Notas>(
                "https://sigecmh.monicaherrera.edu.sv/apiECMH/",
                "api/data",
                "/horarios");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    response.Message, 
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            var milista = (List<Notas>)response.Result;
            this.Notasx = new ObservableCollection<Notas>(notasx);
        }
        #endregion
    }
}
