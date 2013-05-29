﻿Feature: TestFeature

	
Background: open homepage
Scenario: go to homepage
	Given navigate to http://www.fins.com/

Scenario: login OK
	Given I am not logged in
	When I login using paa@intetics.com and Newbuild14
	Then Login Succeeded

Scenario: login failure
	Given I am not logged in
	When I login using paa@intetics.com and incorrectPassword
	Then Login Failed

Scenario: Anonymous Finance - Search for Java Jobs in NY 
	Given I am not logged in
	When The board is Finance
		And I type keyword 'Java'
		And I type location 'New York, NY'
		And I do search
	Then I get More than 100 results