Feature: WebUI

Scenario: Website_things
	Given I go to "https://www.bbc.co.uk/"
	Then the page title is "BBC - Home"
