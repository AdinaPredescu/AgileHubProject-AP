Feature: GoogleSearchTestFeature
	In order to see images via Google Search
	As a user
	I want to be able to search on Google Images

@GoogleSearch
Scenario: ValidateGoogleImagesSearch
	Given I navigate to Google homepage
	And I search for Paris
	When I click on the first resulted image
	Then I should view the picture
		And return to the results page