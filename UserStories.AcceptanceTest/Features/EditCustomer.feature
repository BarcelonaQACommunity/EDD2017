Feature: EditCustomer

Scenario: The user edits an existing customer
	Given The user enters to the home page
	And The user logs with a valid user
	When The user goes to the select edit customer page
	And The user inserts a valid customer id
	And The user clicks the select edit customer submit button
	Then The system dispose the web driver
