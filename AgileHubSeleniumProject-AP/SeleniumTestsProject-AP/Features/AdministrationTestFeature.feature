Feature: AdministrationTestFeature
	In order to manage my CasQa website
	As an admin user
	I want to be able to have edit rights

@AdministrationMenu
Scenario: ValidateAccessToAdministrationMenu
	Given I am logged in as an admin user
	When I navigate to Administration page
	Then I should see the menu

@UsersMenu
Scenario: ValidateAccessToUsersMenu
	Given I am logged in as an admin user
	When I navigate to Administration page
		And I click on the Users menu
	Then I should see a list of users

@EditUserPage
Scenario: ValidateEditUser
	Given I am logged in as an admin user
	When I navigate to Administration page
		And I click on the Users menu
		And I click on the Edit user button
	Then I should be able to edit the user page