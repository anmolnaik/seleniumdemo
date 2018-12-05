@chrome_setup_before_feature @close_current_browser
Feature: DemoPage



Scenario: 01_Search Product
	Given Open Website Url
	Then Search for iphone
	When Click on Search button
	Then Validate first product found

Scenario: 02_Validate Product Price on Home page and poduct page
	Given Open Website Url
	Then Search for Realme U1
	When Click on Search button
	Then Get the price on current product Realme U1
	And validate on product page


Scenario Outline: 03_Amazon Login
	Given Go To Login Page
	Then Enter <username> and <password>
	When  I press login 
	Then Validate The Amazon Logo

Examples: 
	| username               | password  |
	| anmol.naik15@gmail.com | Anmol@922 |