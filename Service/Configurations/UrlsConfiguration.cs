﻿using Core.Configurations.Abstractions;

namespace Service.Configurations
{
    public class UrlsConfiguration : IConfiguration
    {
        public string SectionName => "SalesforceUrls";

        public string? LoginPage { get; set; }
        public string? HomePage { get; set; }
    }
}