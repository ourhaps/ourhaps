using System;
using TechTalk.SpecFlow;

namespace OurHaps.Gherkins.Steps
{
    [Binding]
    public class UserManagementSteps
    {
        [Given(@"tenant admin is on Create user page")]
        public void GivenTenantAdminIsOnCreateUserPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user enters valid user data")]
        public void WhenUserEntersValidUserData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"presses create user button")]
        public void WhenPressesCreateUserButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user is created")]
        public void ThenUserIsCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
