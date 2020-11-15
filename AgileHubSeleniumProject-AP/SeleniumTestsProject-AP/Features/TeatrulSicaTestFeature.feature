Feature: TeatrulSicaTestFeature
	In order to enjoy a theatre show
	As an art lover
	I want to be able to check show details before booking a ticket

@SeeShowDetails
Scenario: See theatre show details
	Given I navigate to Teatrul Sica Alexandrescu website
	When I navigate to the first actor page
		And I select the first displayed show
	Then I should see information about the show