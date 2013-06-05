Feature: Login to FINS
	In order to get to my FINS profile
	As a user
	I want to be able to log in at FINS from all possible places

# HOME PAGE
Scenario: login in the header at home page 
	Given I am not logged in 
		And The board is none
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login in Get Started Now section at home page  
	Given I am not logged in 
		And The board is 'none'
	When I click button 'Get Started Now'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded

# FINANCE 
Scenario: login in the header at Finance board
	Given I am not logged in 
		And The board is Finance
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login by My Dashboard menu at Finance board
	Given I am not logged in 
		And The board is Finance
	When in the menu I click item 'My Dashboard'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded

# TECHNOLOGY
Scenario: login in the header at Technology board 
	Given I am not logged in 
		And The board is 'Technology'
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login by My Dashboard menu at Technology board
	Given I am not logged in 
		And The board is 'Technology'
	When in the menu I click item 'My Dashboard'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded

# SALES
Scenario: login in the header at Sales board 
	Given I am not logged in 
		And The board is 'Sales'
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login by My Dashboard menu at Sales board
	Given I am not logged in 
		And The board is 'Sales'
	When in the menu I click item 'My Dashboard'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded

# STUDENT
Scenario: login in the header at Student board
	Given I am not logged in 
		And The board is 'Student'
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login by My Dashboard menu at Student board
	Given I am not logged in 
		And The board is 'Student'
	When in the menu I click item 'My Dashboard'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded

# EUROPE
Scenario: login in the header at Europe board
	Given I am not logged in 
		And The board is Europe
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login by My Dashboard menu at Europe board
	Given I am not logged in 
		And The board is 'Europe'
	When in the menu I click item 'My Dashboard'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded

# ASIA
Scenario: login in the header at Asia board
	Given I am not logged in 
		And The board is Asia
	When in the header I click button 'Login'
		And in the popup login form I enter login 'paa@intetics.com'
		And in the popup login form I enter password 'Newbuild14'
		And in the popup login form I click button 'Login'
	Then Login Succeeded

Scenario: login by My Dashboard menu at Asia board
	Given I am not logged in 
		And The board is 'Asia'
	When in the menu I click item 'My Dashboard'
		And in the login form I enter login 'paa@intetics.com'
		And in the login form I enter password 'Newbuild14'
		And in the login form I click button 'Login'
	Then Login Succeeded



