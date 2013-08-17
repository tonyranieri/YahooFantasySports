using System.Configuration;

namespace YahooFantasySports.Config
{
    public static class ConfigHelper
    {
        public class Yahoo
        {
            public static string RequestUrl
            {
                get { return GetConfigValueByKey("YahooRequestUrl"); }
                private set { }
            }

            public static string UserAuthorizeUrl
            {
                get { return GetConfigValueByKey("YahooUserAuthorizeUrl"); }
                private set { }
            }

            public static string AccessUrl
            {
                get { return GetConfigValueByKey("YahooAccessUrl"); }
                private set { }
            }

            public static string CallbackUrl
            {
                get { return GetConfigValueByKey("CallbackUrlFromYahooUrl"); }
                private set { }
            }

            public static string FantasySportsUrl
            {
                get { return GetConfigValueByKey("YahooRootFantasySportsUrl"); }
                private set { }
            }

            private static readonly OAuthConfiguration _oAuthConfig = ConfigurationManager.GetSection("oAuthConfig") as OAuthConfiguration;

            public static OAuthConfiguration OAuth
            {
                get 
                { 
                    return _oAuthConfig; 
                }
            }
        }

        #region Private

        private static string GetConfigValueByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        #endregion
    }
}