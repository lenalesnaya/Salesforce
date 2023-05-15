using Core.Configurations;

namespace Service.Configurations
{
    internal class SalesforseConfigurationManager : ConfigurationManager
    {
        public static AccountConfiguration Account => BindConfiguration<AccountConfiguration>();
        public static UrlsConfiguration Urls => BindConfiguration<UrlsConfiguration>();
    }
}