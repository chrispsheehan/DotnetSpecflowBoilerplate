Feature: Github

Background: Go_To_Github
	Given I go to "https://github.com/"
	Then the page title is "GitHub: Where the world builds software · GitHub"

Scenario Outline: Github_home
    When I search for <searchValue>
    Then I see results of <expectedResults>
Examples:
    | searchValue   | expectedResults                                                                       |
    | "something"   | "fishingworld/something, jrainlau/draw-something, fangjian0423/springboot-analysis"   |