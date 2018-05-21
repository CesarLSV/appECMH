namespace appECMH.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string uservalidator
        {
            get { return Resource.uservalidator; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string passwordvalidator
        {
            get { return Resource.passwordvalidator; }
        }


        public static string errorencredenciales
        {
            get { return Resource.errorencredenciales; }
        }



        public static string rememberme
        {
            get { return Resource.rememberme; }
        }
        public static string useryouplaceholder
        {
            get { return Resource.useryouplaceholder; }
        }
        public static string passwordplaceholder
        {
            get { return Resource.passwordplaceholder; }
        }
        public static string password
        {
            get { return Resource.password; }
        }
        public static string userlogin
        {
            get { return Resource.userlogin; }
        }


        public static string admissions
        {
            get { return Resource.admissions; }
        }
        public static string enter
        {
            get { return Resource.enter; }
        }
       


    }
}
