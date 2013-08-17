using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Framework;
using YahooFantasySports.Config;
using YahooFantasySports.Session;

namespace YahooFantasySports.Services
{
    public interface IYahooFantasySportsService
    {
        string BeginAuthenticate();
        string GetLeaguesForUser(string userId);
        string GetGamesForLeague(string leagueId); //do-able?
        string GetAthletesForTeam(string teamId);
        string GetAvailableAthletesForGame(string gameId);
    }

    public class YahooFantasySportsService : IYahooFantasySportsService
    {
        public string BeginAuthenticate()
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

            return authorizationLink;
        }

        public string GetLeaguesForUser(string userId)
        {
            throw new NotImplementedException();
        }

        public string GetGamesForLeague(string leagueId)
        {
            throw new NotImplementedException();
        }

        public string GetAthletesForTeam(string teamId)
        {
            throw new NotImplementedException();
        }

        public string GetAvailableAthletesForGame(string gameId)
        {
            throw new NotImplementedException();
        }
    }

}