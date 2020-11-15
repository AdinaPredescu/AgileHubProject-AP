Feature: CasQaAddToCartTestFeature
	In order to place an order
	As a customer
	I want to be able to add products to cart

@AddToCartAsRegularUser
Scenario: Check adding products to cart as regular user
	Given I navigate to CasQa website
	And I login as a regular user
	When I add a product to the cart
	Then Comanda Acum button is displayed

@AddToCartAsAdminUser
Scenario: Check adding products to cart as an admin user
	Given I navigate to CasQa website
	And I login as an admin user
	When I add a product to the cart
	Then Comanda Acum button is displayed