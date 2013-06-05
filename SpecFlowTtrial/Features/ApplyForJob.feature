Feature: Applying For A Job 
	In order to get new job 
	As a user
	I want to be able to apply for a job

Background: 

Scenario: Search and Apply For Dow Jones Job in US
	Given I am not logged in
		And The board is Finance
	When in the header I select country 'US'
		And in the header I type keyword 'dow jones'
		And in the header I search for all
		And in the Jobs list I click Job 1 
		And in the Job page I click button 'Apply' 
		And in the Job page I click button 'Go To Employer Website' 
	Then Employer website is opened in new window at 'dowjones.taleo.net'
		And Job page contains the text 'You left FINS to apply to' 

Scenario: Search and Apply For Dow Jones Job in US via Indeed
	Given I am not logged in
		And The board is Finance
	When in the header I select country 'US'
		And in the header I type keyword 'dow jones'
		And in the header I search for 'all'
		And in the Jobs list I click Job 1
		And in the URL I add '&utm_source=Indeed&utm_medium=organic'
		And in the Job page I click button 'Apply' 
		And in the Job page I click button 'Go To Employer Website' 
	Then Employer website is opened in new window at 'dowjones.taleo.net'
		And Job page contains the text 'You left FINS to apply to' 
	

