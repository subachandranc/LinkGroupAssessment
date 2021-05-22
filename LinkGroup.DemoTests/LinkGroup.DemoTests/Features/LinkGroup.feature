Feature: LinkGroup
	Search the text in Home page

@Scenario 
Scenario: Search the given text in Home page
	Given I have opened the Home page
	And I have agreed to the cookie policy
	When I search for 'Leeds'
	Then The search results are displayed

	Scenario Outline: Juristrictions
	When I open the found solutions page
	Then I can select the <Jurisrction name> Juristriction
	Examples: 
	| Juristriction name |
	| United Kingdom     |
	| Switzerland       |