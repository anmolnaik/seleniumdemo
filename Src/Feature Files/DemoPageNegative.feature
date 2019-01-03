@chrome_setup_before_feature @close_current_browser
Feature: DemoPageNegative

Scenario: 01_Amazon Login
	Given Go To Login Page
	Then Set incorrect username anmol.naik15@gmail.com and password  Anmol@000
	When  I press login 
	Then Validate incorrect password error message

Scenario: 02_Amazon Login
	Given Go To Login Page
	Then Enter incorrect emailid anmol.naik90@gmail.com	 
	Then Validate incorrect email error message

Scenario: 03_Amazon Login
	Given Go To Login Page
	When Enter blank Email id	

Scenario: Table Structure
	When Sameple data of table
		| Name	| Age |
		| Anmol |  26 |

Scenario: Json Data Read and write
	Given Read data from jsonfile
	Then write data to json file
	Then A customer updates color of product from Black to Red