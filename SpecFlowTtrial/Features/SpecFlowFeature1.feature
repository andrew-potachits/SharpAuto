Feature: TestFeature

	
Background: open homepage
Scenario: go to homepage
	Given navigate to http://www.fins.com/

Scenario: login OK
	Given I am not logged in
	When I enter paa@intetics.com and Newbuild14
	Then Login Succeeded

Scenario: login failure
	Given I am not logged in
	When I enter paa@intetics.com and incorrectPassword
	Then Login Failed

