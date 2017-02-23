Feature: EditCustomer

Scenario: The user edits an existing customer
	Given The user enters to the home page
	And The user logs with a valid user
	When The user goes to the select edit customer page
	And The user inserts a valid customer id
	And The user clicks the select edit customer submit button
    And The user edit a customer with parameters 'Plaza Catalunya', 'Barcelona', 'Barcelona', '123456', '666123444'
    And The user clicks the submit button
	Then The customer with parameters 'Juan Serna', '15121990', 'Male', 'Plaza Catalunya', 'Barcelona', 'Barcelona', '123456', '666123444' has been edited
