Feature: Creates a new customer

Scenario: The user can creates a new customer
	Given The user enters to the home page
	And The user logs with a valid user
	When The user goes to the new customer page
	And The user creates a new customer with parameters 'Juan', '15121990', 'Male', 'Plaza Catalunya', 'Barcelona', 'Barcelona', '123456', '666123444', '111222333'
	And The user clicks the submit button
	Then The customer with parameters 'Juan', '15121990', 'Male', 'Plaza Catalunya', 'Barcelona', 'Barcelona', '123456', '666123444', '111222333' has been created
	And The system dispose the web driver

Scenario Outline: The user tries to create a new customer with empty parameters
	Given The user enters to the home page
	And The user logs with a valid user
	When The user goes to the new customer page
	And The user creates a new customer with parameters '<name>', '<date>', '<gender>', '<address>', '<city>', '<state>', '<pin>', '<mobile>', '<password>'
	And The user clicks the submit button
	Then The customer cannot be created
	And The system dispose the web driver

	Examples: 
	| name		| date		| gender	| address			| city		| state		| pin		| mobile	| password	|
	| empty		| 15121990	| Male		| Plaza Catalunya	| Barcelona | Barcelona | 123456	| 666123444 | 111222333 |
	| Juan		| empty		| Male		| Plaza Catalunya	| Barcelona | Barcelona | 123456	| 666123444 | 111222333 |
	| Juan		| 15121990	| Male		| empty				| Barcelona | Barcelona | 123456	| 666123444 | 111222333 |
	| Juan		| 15121990	| Male		| Plaza Catalunya	| empty	    | Barcelona | 123456	| 666123444 | 111222333 |
	| Juan		| 15121990	| Male		| Plaza Catalunya	| Barcelona | empty		| 123456	| 666123444 | 111222333 |
	| Juan		| 15121990	| Male		| Plaza Catalunya	| Barcelona | Barcelona | empty 	| 666123444 | 111222333 |
	| Juan		| 15121990	| Male		| Plaza Catalunya	| Barcelona | Barcelona | 123456 	| empty		| 111222333 |
	| Juan		| 15121990	| Male		| Plaza Catalunya	| Barcelona | Barcelona | 123456 	| 666123444	| empty		|
