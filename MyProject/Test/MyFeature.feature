Feature: Google Search
    In order to find relevant information
    As a user
    I want to search for a keyword on Google
   
   @smoke
Scenario: Search for a keyword
    Given I am on the Google search page
    When I enter "GitHub Actions" in the search box
    And I click the search button
    Then I should see search results for "GitHub Actions"
