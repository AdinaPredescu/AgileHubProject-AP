Feature: UntoldTestFeature
	In order to find out more details about Untold Festival
	I want to be able to see the festival homepage

@mytag
Scenario: See Untold HomePage
	Given I navigate to Untold website
	When I click on the navigation menu from the top right hand corner
	Then I should see Home option