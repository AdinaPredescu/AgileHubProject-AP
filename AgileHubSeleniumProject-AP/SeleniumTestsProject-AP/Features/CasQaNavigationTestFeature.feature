Feature: CasQaNavigationTestFeature
	In order to see that my website is up and running
	As a potential customer
	I want to be able to access all the menus from the homepage

@PageNavigation
Scenario: ValidatePageNavigation
	Given I navigate to Casqa website
	Then I should be able to access all the horizontal pages