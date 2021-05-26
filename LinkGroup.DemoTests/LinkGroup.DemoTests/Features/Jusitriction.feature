Feature: Link Fund solutions
	Search the text in Home page

@mytag
Scenario Outline: Juristrictions
	When I open the found solutions page
	Then I can select the <Jurisrction name> Juristriction
	Examples: 
	| Juristriction name |
	| United Kingdom     |
	| Switzerland        |