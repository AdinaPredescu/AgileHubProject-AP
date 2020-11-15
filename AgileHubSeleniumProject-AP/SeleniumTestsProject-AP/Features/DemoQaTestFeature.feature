Feature: DemoQaTestFeature
	In order to practice my automation skills
	As an automation tester
	I want to be able to register to Demoqa webiste

@ValidateRegisterAccount
Scenario: Register an account to DemoQa website
	Given I navigate to DemoQa website
	When I fill in the registration form
	Then my account should be submitted

@ValidateRegisterTextBoxInfo
Scenario: Register textbox info to DemoQa website
	Given I navigate to DemoQa textbox information website page
	When I fill in all the required fields
	Then my entered information should be submitted