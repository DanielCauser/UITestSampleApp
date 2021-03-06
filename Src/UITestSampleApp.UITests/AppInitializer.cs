﻿using Xamarin.UITest;

namespace UITestSampleApp.UITests
{
    static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return ConfigureApp.Android.StartApp();

                case Platform.iOS:
                    return ConfigureApp.iOS.StartApp();

                default:
                    throw new System.NotSupportedException();
            }
        }
    }
}

