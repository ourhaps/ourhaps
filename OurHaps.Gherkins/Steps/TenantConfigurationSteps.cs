using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace OurHaps.Gherkins.Steps
{
    [Binding]
    public class TenantConfigurationSteps
    {
        private Tenant _tenant { get; set; }

        [Fact]
        [Given(@"tenant admin is on tenant configuration page")]
        public void GivenTenantAdminIsOnTenantConfigurationPage()
        {
            using(IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, new ChromeOptions {AcceptInsecureCertificates = true }))
            {
                driver.Navigate().GoToUrl("https://localhost:44322/TenantConfiguration");
            }
        }

        [Fact]
        [When(@"tenant admin enters (.*) and presses save")]
        public void WhenTenantAdminEntersTenantNameAndPressesSave(string tenantName)
        {
            using (IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, new ChromeOptions { AcceptInsecureCertificates = true }))
            {
                var tenantNameField = driver.FindElement(By.Id("tenantName"));
                tenantNameField.SendKeys(tenantName);
                tenantNameField.Submit();
            }
        }

        [Fact]
        [Then(@"the tenant name is updated to (.*)")]
        public void ThenTheTenantNameIsUpdatedTo(string tenantName)
        {
            FluentAssertions.Exactly.Equals(tenantName, _tenant.Name);
        }
    }

    public class Tenant
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    public class TenantService
    {
        public string GetTenantName(Guid id)
        {
            return string.Empty;
        }
    }
}
