Feature: TMFeature

As a Turnup portal admin
I would like to create, edit and delete Time and Material record.
So that i can manage employees Time and Material successfully.


@tag1
Scenario: 1)Create Material Record with valid data
	Given I logged into Turnup portal successfully
	When I navigate to Time and Material page
	When I create a new Material record
	Then The record should be created successfully

Scenario Outline: 2)Edit existing material with valid data
    Given I logged into Turnup portal successfully
	When I navigate to Time and Material page
	When I update '<Code>','<Description>' and '<Price>' of an existing material record 
	Then The record '<Code>','<Description>' and '<Price>' of an existing material should be updated 
	Examples: 
	| Code   | Description  | Price   |
	| Books  | Harry Potter | $100.00 |
	| Pen    | Red          | $30.00  |
	| Pencil | Natraj       | $15.00  |
Scenario: 3)Delete existing material record 
	Given I logged into Turnup portal successfully
	When I navigate to Time and Material page
	When I delete an existing Material record
	Then The record should be deleted successfully