Feature: Github

Scenario: Github_home
	Given I go to "https://github.com/"
	Then the page title is "GitHub: Where the world builds software · GitHub"
    When I search for "something"
    Then I see results of "fishingworld/something, jrainlau/draw-something, fangjian0423/springboot-analysis"