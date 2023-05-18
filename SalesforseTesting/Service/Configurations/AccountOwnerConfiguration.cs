using Core.Configurations.Abstractions;

namespace SalesforceTesting.Service.Configurations
{
    public class AccountOwnerConfiguration : IConfiguration
    {
        public string SectionName => "AccountOwner";

        public string? Username {  get; set; }
        public string? Password { get; set; }
    }
}