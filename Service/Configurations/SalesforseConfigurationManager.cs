﻿using Core.Configurations;

namespace Service.Configurations
{
    public class SalesforseConfigurationManager : ConfigurationManager
    {
        public static AccountOwnerConfiguration AccountOwner => BindConfiguration<AccountOwnerConfiguration>();
        public static AccountConfiguration Account => BindConfiguration<AccountConfiguration>();
        public static UrlsConfiguration Urls => BindConfiguration<UrlsConfiguration>();
    }
}