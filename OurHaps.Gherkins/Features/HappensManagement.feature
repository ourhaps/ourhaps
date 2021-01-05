Feature: HappensManagement

Scenario: Create Happens
Given user is on Hap details page
When user enters valid data
And user clicks create Happens button
Then a Happens is created
Then subscribed users get a notification

Scenario: Modify Happens
Given user is on Hap details page
When user modifies Happens data
And user clicks save button
Then Happens is updated
Then subscribed users get a notification

Scenario: View Happens
Given user is on Hap details page
When user clicks on Happens
Then user is redirected to Happens overview page

Scenario: Remove Happens
Given user is on Hap details page
When user clicks delete button
Then Happens is deleted
Then subscribed users get a notification

Scenario: Invite to Happens
Given user is on Hap details page
When user enters valid email/s
And user clicks on invite button
Then an invitation is sent to email/s

Scenario: Accept Happens invitation
Given user opens invitation
When user clicks accept button
Then user is added to Happens

Scenario: Decline Happens invitation
Given user opens invitation
When user clicks decline button
Then user is removed from Happens
