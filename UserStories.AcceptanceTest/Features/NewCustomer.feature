Feature: Creates a new customer

Scenario: The user can creates a new customer
	Given The user enters to the home page
	And The user logs with a valid user
	When The user goes to the new customer page
	And The user creates a new customer with parameters 'Juan', '15121990', 'Male', 'Plaza Catalunya', 'Barcelona', 'Barcelona', '123456', '666123444', 'email@email.com', '111222333'
