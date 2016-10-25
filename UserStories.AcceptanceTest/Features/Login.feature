Feature: Login

Scenario: The user can login into the home page
	Given The user enters to the home page
	When The user logs with a valid user
	Then The user has logged correctly
