using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YahooFantasySports.Session
{
    public static class SessionHelper
    {
        //todo: extract/encapsulate stuff to base classes/interfaces

        private const string OAuthSessionKey = "OAuthSession";
        private const string OAuthTokenKey = "OAuthToken";

        public static OAuthSession OAuthSession
        {
            get { return GetValue<OAuthSession>(OAuthSessionKey); }
            set { SetValue(OAuthSessionKey, value);}
        }

        public static IToken OAuthToken
        {
            get { return GetValue<IToken>(OAuthTokenKey); }
            set { SetValue(OAuthTokenKey, value); }
        }

        #region Private

        private static T GetValue<T>(string key)
        {
            return (T) HttpContext.Current.Session[key];
        }

        private static void SetValue<T>(string key, T value)
        {
            HttpContext.Current.Session.Add(key, value);
        }

        #endregion
    }
}