Feature: SessionHandling

Scenario: Login
Given a user on the startpage
When user enters valid tenant admin credentials
And presses login button
Then user is logged in

Scenario: Logout
Given user is logged in
When user presses logout button
Then user is logged out
And routed to the startpage

Scenario: Session timeout
Given user is logged in
When user is inactive for 20 minutes
Then user is logged out
And routed to the startpage
