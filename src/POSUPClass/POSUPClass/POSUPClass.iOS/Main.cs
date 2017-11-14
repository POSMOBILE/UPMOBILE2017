using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace POSUPClass.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }

        /*
         * 
         * /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets(3,3): Warning MSB3247: Found conflicts between different versions of the same dependent assembly. In Visual Studio, double-click this warning (or select it and press Enter) to fix the conflicts; otherwise, add the following binding redirects to the "runtime" node in the application configuration file: <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Net.Http" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-4.0.0.0" newVersion="4.0.0.0" /></dependentAssembly></assemblyBinding> (MSB3247) (POSUPClass.Android)

            */
    }
}
