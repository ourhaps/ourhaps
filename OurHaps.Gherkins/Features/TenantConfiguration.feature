Feature: TenantConfiguration

Scenario: Specify tenant name
Given tenant admin is on tenant configuration page
When tenant admin enters Guns N roses World Tour and presses save
Then the tenant name is updated to Guns N roses World Tour

Scenario: Tenant signup

@auth
Scenario: Authentication configuration

@rss
Scenario: Disable RSS

@rss
Scenario: Enable RSS

@api
Scenario: Enable API

@api
Scenario: Disable API
