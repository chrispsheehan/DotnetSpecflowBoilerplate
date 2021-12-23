Feature: WebUI

@mytag
Scenario: Website things
	Given I go to "https://www.bbc.co.uk/"
	Then the page title is "Home"
