using System;
using TechTalk.SpecFlow;

namespace OurHaps.Gherkins.Steps
{
    [Binding]
    public class SessionHandlingSteps
    {
        [Given(@"a user on the startpage")]
        public void GivenAUserOnTheStartpage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"user is logged in")]
        public void GivenUserIsLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
             
        [When(@"user enters valid tenant admin credentials")]
        public void WhenUserEntersValidTenantAdminCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"presses login button")]
        public void WhenPressesLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user presses logout button")]
        public void WhenUserPressesLogoutButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user is inactive for (.*) minutes")]
        public void WhenUserIsInactiveForMinutes(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user is logged in")]
        public void ThenUserIsLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user is logged out")]
        public void ThenUserIsLoggedOut()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"routed to the startpage")]
        public void ThenRoutedToTheStartpage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
