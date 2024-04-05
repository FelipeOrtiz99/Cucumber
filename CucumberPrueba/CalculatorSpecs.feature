Feature: Calculator Specs
	As a math fan
	I Want to have a calculator
	So that I can add and multiply numbers

Scenario: Add Numbers
	Given I have 2 as the first number
	And I have 3 as the second number
	When I ask to add up these numbers
	Then I receive 5 as a result

Scenario: Multiply Numbers
	Given I have 4 as the first number
	And I have 5 as the second number
	When I ask to multiply these numbers
	Then I receive 20 as a result