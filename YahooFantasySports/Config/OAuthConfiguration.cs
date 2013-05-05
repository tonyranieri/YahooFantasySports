using System.Configuration;

namespace YahooFantasySports.Config
{
    /// <summary>
    /// I'd like to be able to refactor this into a more generic class that would just obtain an "oauth config" node but then 
    /// the config node structure needs to change and I'm not doing the work for something I don't need just yet...
    ///
    /// Would need to look something like:
    ///   oAuthConfiguration
    ///     - Yahoo
    ///         - ConsumerKey
    ///         - ConsumerSecret
    /// 
    /// This would allow the actual config section piece to remain the same accross different providers, and only require a 
    /// change to the root/parent node
    /// </summary>
    public class OAuthConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("YahooConsumerKey", DefaultValue = "", IsRequired = true)]
        public string ConsumerKey
        {
            get { return (this["YahooConsumerKey"] ?? string.Empty).ToString(); }
            set { this["YahooConsumerKey"] = value; }
        }

        [ConfigurationProperty("YahooConsumerSecret", DefaultValue = "", IsRequired = true)]
        public string ConsumerSecret
        {
            get { return (this["YahooConsumerSecret"] ?? string.Empty).ToString(); }
            set { this["YahooConsumerSecret"] = value; }
        }
    }
}