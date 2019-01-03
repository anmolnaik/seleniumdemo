@chrome_setup_before_feature @close_current_browser
Feature: DemoPage

Scenario: 01_Search Product
	Given Open Website Url
	Then Search for iphone
	When Click on Search button
	Then Validate first product found

Scenario: 02_Validate Price Filter 
	Given Open Website Url
	Then Search for phone
	When Click on Search button
	Then Validate price list of product under Under ₹1,000	

Scenario: 03_Validate Product Price on Home page and poduct page
	Given Open Website Url
	Then Search for Realme U1
	When Click on Search button
	Then Get the price on current product Realme U1
	And validate on product page

Scenario: 04_Validate deletion of product
	Given Open Website Url
	Then Search for Nokia 105 (Black)
	When Click on Search button
	Then Select product Nokia 105 (Black)
	When Product added to the cart
	Then Delete product added to cart
	And Validate Cart is Empty

Scenario: 05_Validate Product price in Cart
	Given Open Website Url
	Then Search for Nokia 105 (Black)
	When Click on Search button
	Then Get the price on current product Nokia 105 (Black)
	When Update product quantity
	And Product added to cart
	Then Validate updated product price

Scenario: 06_Validate Brand Filter 
	Given Open Website Url
	Then Search for Samsung
	When Click on Search button
	Then Select filter for Samsung
	And Validate list of Samsung products

Scenario: 07_Add Product to Wishlist 
	Given Go to url and login username : anmol.naik15@gmail.com password : Anmol@922 
	Then Search for Nokia 105 (Black)
	When Click on Search button
	Then Get the price on current product Nokia 105 (Black)	
	Then Product added to wishlist Nokia 105 (Black)
	Then Customer closes tab and log out from website

Scenario: 08_Amazon Login
	Given Go to url and login username : anmol.naik15@gmail.com password : Anmol@922  
	Then Log out from website

Scenario: 09_Edit profile for Amazon
	Given Go to url and login username : anmol.naik15@gmail.com password : Anmol@922 
	When I clicked on Your Orders
	And  I clicked on login and security
	Then I update Roks
	Then Log out from website

Scenario: 10_Update password for Amazon
	Given Go to url and login username : anmol.naik15@gmail.com password : Anmol@922 
	When I clicked on Your Orders
	And  I clicked on login and security
	Then Account password update
	Then Log out from website	

Scenario: 11_Validate Prime link
	Given Open Website Url
	Then Home page logo prime link
	Then Home page prime dropdown link

Scenario: 12_Validate Prime Vedio link
	Given Open Website Url
	Then  Home Page Prime vedio link 
	
Scenario: 13_Add product from wishlist to cart
	Given Go to url and login username : anmol.naik15@gmail.com password : Anmol@922 
	Then Search for Nokia 105 (Black)
	When Click on Search button
	Then Get the price on current product Nokia 105 (Black)	
	Then Product added to wishlist Nokia 105 (Black)
	Then Add product to cart from wishlist
	And Validate message Product added to cart
	Then Log out from website

Scenario: 14_Validate previously added product to cart
	Given Go to url and login username : anmol.naik15@gmail.com password : Anmol@922 
	Then Go to cart from home page
	And Validate and remove product from cart Nokia 105 (Black)
	Then Log out from website
	

