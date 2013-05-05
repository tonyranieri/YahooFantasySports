//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Web;

//namespace YahooFantasySports
//{
//    //public static class YahooHelper
//    //{
//    //    public static string RequestUrl
//    //    {
//    //        get { return }
//    //        private set { }
//    //    }
//    //    public static string UserAuthorizeUrl
//    //    {
//    //        get { throw new NotImplementedException(); }
//    //        private set { }
//    //    }
//    //    public static string AccessUrl
//    //    {
//    //        get { throw new NotImplementedException(); }
//    //        private set { }
//    //    }
//    //    public static string CallbackUrl
//    //    {
//    //        get { throw new NotImplementedException(); }
//    //    }
//    //}

//    public static class ConfigHelper
//    {
//        public static class Yahoo
//        {
//            public static string RequestUrl
//            {
//                get { return GetConfigValueByKey("YahooRequestUrl"); }
//                private set { }
//            }

//            public static string UserAuthorizeUrl
//            {
//                get { return GetConfigValueByKey("YahooUserAuthorizeUrl"); }
//                private set { }
//            }

//            public static string AccessUrl
//            {
//                get { return GetConfigValueByKey("YahooAccessUrl"); }
//                private set { }
//            }

//            public static string CallbackUrl
//            {
//                get { return GetConfigValueByKey("CallbackUrlFromYahooUrl"); }
//                private set { }
//            }

//            public static string FantasySportsUrl
//            {
//                get { return GetConfigValueByKey("YahooRootFantasySportsUrl"); }
//                private set { }
//            }

//            private static readonly OAuthConfiguration _oAuthConfig = ConfigurationManager.GetSection("oAuthConfig") as OAuthConfiguration;

//            public static OAuthConfiguration OAuth
//            {
//                get { return _oAuthConfig; }
//            }
//        }

//        #region Private

//        private static string GetConfigValueByKey(string key)
//        {
//            return ConfigurationManager.AppSettings[key];
//        }

//        #endregion
//    }


//}