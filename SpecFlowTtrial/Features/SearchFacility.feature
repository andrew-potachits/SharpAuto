Feature: Search Facility
 As a user
 I want to be able to search for jobs

# FINANCE
Scenario: Finance - search by keyword and location from header
 Given I am not logged in
  And The board is Finance
 When in the header I type keyword 'Account'
  And in the header I type location 'New York, NY'
  And in the header I select country 'US'
  And in the header I search for jobs
 Then Search has more than 100 jobs
  And Search has more than 20 companies
  And Search has more than 120 overall results


# TECHNOLOGY
Scenario: Technology - search by keyword and location from header
 Given I am not logged in
  And The board is IT
 When in the header I type keyword 'database'
  And in the header I type location 'Princeton, NJ'
  And in the header I select country 'US'
  And in the header I search for jobs
 Then Search has more than 20 jobs
  And Search has more than 3 companies
  And Search has more than 50 overall results

# SALES
Scenario: Sales - search by keyword and location from header
 Given I am not logged in
  And The board is Sales
 When in the header I type keyword 'sales'
  And in the header I type location 'New York, NY'
  And in the header I select country 'US'
  And in the header I search for jobs
 Then Search has more than 20 jobs
  

# EUROPE
Scenario: Europe - search by keyword and location from header
 Given I am not logged in
  And The board is Europe
 When in the header I type keyword 'dow jones'
  And in the header I type location 'London'
  And in the header I select country 'UK'
  And in the header I search for jobs
 Then Search has more than 10 jobs

# ASIA
Scenario: Asia - search by keyword and location from header
 Given I am not logged in
  And The board is Asia
 When in the header I type keyword 'PricewaterhouseCoopers'
  And in the header I type location 'Beijing'
  And in the header I select country 'CN'
  And in the header I search for jobs
 Then Search has more than 10 jobs
