Feature: Login

Scenario: The user can login into the home page
	Given The user enters to the home page
	When The user logs with a valid user
	Then The user 'mngr52720' has logged correctly

Scenario: The user cannot login into the home page
	Given The user enters to the home page
	When The user logs with an invalid user
	Then The web throws a pop up
