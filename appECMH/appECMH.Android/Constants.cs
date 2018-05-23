using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace appECMH.Droid
{
    class Constants
    {

        public const string SenderID = "957350731953"; //Google Api Project number
        public const string ListenConnectionString = "Endpoint=sb://appecmh.servicebus.windows.net/; " +
            "SharedAccessKeyName=DefaultFullSharedAccessSignature; " +
            " SharedAccessKey=MCK2SaXhZiJEngKQZZFs8jFQ2RQ2wWlH/s192LEtqHY=";
        public const string NotificationHubName = "appECMH";


    }
}