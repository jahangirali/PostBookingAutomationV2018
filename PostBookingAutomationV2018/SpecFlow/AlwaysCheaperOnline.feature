Feature: AlwaysCheaperOnline
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have a booking
	When I navigate to UpsellSeatPage in this '<Language>' language
	Then the text will be '<Text>' as expected
Examples: 
| Language | Text                           |
| EN       | Always cheaper online          |
| FR       | Toujours moins cher en ligne ! |
