using Bogus;
using SalesforceTesting.Service.Configurations;

namespace SalesforceTesting.BusinessObjects.Models.Utilities
{
    public class AccountOwnerBuilder
    {
        static readonly Faker faker = new();

        public static AccountOwner StandartAccountOwner => new()
        {
            Username = SalesforseConfigurationManager.AccountOwner.Username,
            Password = SalesforseConfigurationManager.AccountOwner.Password
        };

        public static AccountOwner GetRandomAccountOwner() => new()
        {
            Username = faker.Internet.Email(provider: "AT_TMSQAC01_TEST.automation"),
            Password = faker.Internet.Password(10)
        };

        public static AccountOwner CreateUser(string username, string password)
        {
            return new AccountOwner()
            {
                Username = username,
                Password = password
            };
        }
    }
}