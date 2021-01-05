Feature: HapManagement

Scenario: Create Hap
Given user is on create Hap page
When user enters valid user data
And presses create hap button
Then a Hap is created

Scenario: View Hap
Given user is on Hap list overview page
When user clicks on a Hap
Then Hap details is displayed

Scenario: Modify Hap
Given user is on Hap details page
When user modifies data
Then Hap is updated

Scenario: Remove Hap
Given user is on Hap details page
When user clicks remove button
Then Hap is removed

Scenario: Invite to Hap
Given user is on Hap overview page or Hap details page
When user enters valid email
And user clicks on invite button
Then an invitation is sent to email


Scenario: Decline Hap invitation
Given user is invited to Hap
When user decline Hap invitation
Then user is blocked from any Happens invitation for given Hap
