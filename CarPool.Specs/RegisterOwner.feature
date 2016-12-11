Feature: Register Owner
	In order to use the services of the app
	Vehicle owners should be able to
	Register

Scenario: Registration with valid details sends confirmation email
	Given I am on the registration page
	And I entered name "Ben" employee id "e1234" email "ben@email.com" and phone "9630123456"
	When click on Register
	Then send confirmation email "Registration successful"

Scenario: Registration with invalid details shows validation message
	Given I am on the registration page
	And I entered name "Ben" employee id "e1234" email "ben" and phone "9630123456"
	When click on Register
	Then display message "Invalid registration details" for invalid input