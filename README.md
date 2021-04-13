# WebScraper
This is a simple .NET console application published on a Windows Server 2012. It is a simple web scraper that sends a message on a Discord Server with the details from a specified website.
The GenericWebScraper.cs class contains a method that lets the user request data from a specific XPath from the desired URL. 
In this particular case I requested the price and the product name from different stores then I get a message on my Discord Server.
I run the application on the Windows Server and I used the Thread.Sleep() method to get a message on Discord once/day.

# What I've Learned
- a little bit about working with Selenium Framework and webdriver
- XPath syntax and overall about the manipulaton through webdrivers
- how to make a Discord Bot with a webhook, Bot that will send a message on a specified sever

# Bugs Discovered/ Things to be improved in the future
Right now the application gets the specified information from the website once per day. What can be improved is to modify the app to send a message on Discord whenever it detects a change in the fields your are following rather than just once/day.
