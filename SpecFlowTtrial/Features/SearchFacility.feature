Feature: Search Facility
	As a user
	I want to be able to search for jobs

Scenario: Finance - search from header
	Given I am not logged in
		And The board is Finance
	When in the header I type keyword 'Account'
		And in the header I type location 'New York, NY'
		And in the header I select country 'US'
		And in the header I search for jobs
	Then Search has more than 100 jobs
		And Search has more than 20 companies
		And Search has more than 120 overall results
