﻿Feature: Creates a new account

Scenario Outline: The user can creates a new account
    Given The user enters to the home page
    And The user logs with a valid user
    When The user goes to the new account page
    And The user creates a new account with parameters '<customerId>', '<accountType>', '<initialDeposit>'

    Examples: 
    | customerId | accountType | initialDeposit |
    | 56274      | Current     | 500            |
    | 56274      | Savings     | 500            |