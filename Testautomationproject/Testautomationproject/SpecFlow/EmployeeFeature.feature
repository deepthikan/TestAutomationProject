Feature: EmployeeFeature

As a Turnup portal admin
I would like to create, edit and delete Employee records.
So that i can manage employee records successfully.

@tag1
Scenario: 1)Create Employees Record with valid data
	Given I logged into Turnup portal 
	When I navigate to Employees page
	When I create a new Employee record
	Then The employee record should be created successfully


Scenario Outline: 2)Edit existing employee with valid data
    Given I logged into Turnup portal 
	When I navigate to Employees page
	When I update '<Name>','<Username>','<Password>' and '<Retypepassword>' of an existing employee record 
	Then The record '<Name>','<Username>','<Password>' and '<Retypepassword>' of an existing employee should be updated 
	Examples: 
	| Name    | Username   | Password     | Retypepassword |
	| DEEPTHI | DAKSHAYANI | @utomatioN12 | @utomatioN12    |
	| Emily   | EMILY      | @utomatioN12 | @utomatioN12    |
	| KAVYA   | kavya      | @utomatioN12 | @utomatioN12    |  


Scenario: 3)Delete existing employee record 
	Given I logged into Turnup portal 
	When I navigate to Employees page
	When I delete an existing employee record
	Then The record should be deleted 