Feature: 
	Ascending order functionality.
	
Scenario: Add to cart functionality
	Given I launch the application
	And Click on add to cart button
	And Click on remove button
	Then Product should be deleted

Scenario: Perform ascending order in product page.
	Given I launch the application
	And I click on any product category
	And I enter click on sort by function
	And I select ascending sort Name(A-Z)
	Then I should see product page sorted in ascending way

Scenario: Quick view of the product
	Given I launch the application
	And I go to women page
	And I click on Quick view button
	Then I should see the product single page
