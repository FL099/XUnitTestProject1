Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@mytag
Scenario: Subtract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are subtracted
	Then the result should be 20

@mytag
Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 3
	When the two numbers are multiplied
	Then the result should be 150

@mytag
Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 5
	When the first number is divided by the second
	Then the result should be 10