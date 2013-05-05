using System;
using System.Web.Mvc;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Framework;
using YahooFantasySports.Config;
using YahooFantasySports.Session;

namespace YahooFantasySports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpPost]
        public ActionResult Authenticate()
        {
            var consumerContext = new OAuthConsumerContext
            {
                ConsumerKey = ConfigHelper.Yahoo.OAuth.ConsumerKey,
                SignatureMethod = SignatureMethod.HmacSha1,
                ConsumerSecret = ConfigHelper.Yahoo.OAuth.ConsumerSecret
            };

            var session = new OAuthSession(consumerContext,
                                           ConfigHelper.Yahoo.RequestUrl,
                                           ConfigHelper.Yahoo.UserAuthorizeUrl,
                                           ConfigHelper.Yahoo.AccessUrl,
                                           ConfigHelper.Yahoo.CallbackUrl);

            var requestToken = session.GetRequestToken();
            var authorizationLink = session.GetUserAuthorizationUrlForToken(requestToken, ConfigHelper.Yahoo.CallbackUrl);

            SessionHelper.OAuthSession = session;
            SessionHelper.OAuthToken = requestToken;

            return Redirect(authorizationLink);
        }

        public ActionResult Query()
        {
            //todo: persist the oauth values?  this would allow repeat visitors w/o requiring multiple yahoo authorizations for each visit

            var session = SessionHelper.OAuthSession;
            var requestToken = SessionHelper.OAuthToken;

            var oauth_verifier = Request.QueryString["oauth_verifier"];
            
            if (!String.IsNullOrEmpty(oauth_verifier))
            {
                session.ExchangeRequestTokenForAccessToken(requestToken, oauth_verifier);
                SessionHelper.OAuthSession = session;
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Query(string text)
        {
            var query = text;
            //todo: encapsulate the oauth calls into a service or something
            var responseText = SessionHelper.OAuthSession.Request().Get().ForUrl(ConfigHelper.Yahoo.FantasySportsUrl + query);

            ViewBag.Message = responseText.ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
