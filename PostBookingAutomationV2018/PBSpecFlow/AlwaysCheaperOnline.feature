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
| Language | Text                             |
| CA       | En línia, sempre és més econòmic |
| CS       | Online vždy levněji              |
| DA       | Altid billigere online           |
| DE       | Online immer günstiger           |
| EL       | Πάντα πιο φθηνά online           |
| EN       | Always cheaper online            |
| ES       | Más económico en línea           |
| FR       | Toujours moins cher en ligne !   |
| HU       | Online mindig olcsóbb            |
| IT       | Sempre più economico online      |
| NL       | Altijd goedkoper online          |
| PL       | Zawsze taniej przez Internet     |
| PT       | Sempre mais barato online        |