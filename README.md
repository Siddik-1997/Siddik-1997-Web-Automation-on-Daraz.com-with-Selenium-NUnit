# Web Automation on Daraz – End-to-End Purchase Flow
 Using Selenium WebDriver with C# & NUnit
# What is Automation?

Automation is the process of using software tools and scripts to perform tasks that are traditionally executed manually. In software testing, automation helps execute test cases automatically, validate expected results, and ensure application quality with greater speed, accuracy, and repeatability.

# Why Selenium with C# NUnit?

Selenium WebDriver is a widely used open-source tool for automating web browsers. It allows testers to interact with web elements just like a real user—clicking buttons, filling forms, navigating pages, and validating UI behavior.

NUnit is a powerful unit-testing framework for .NET. When combined with Selenium and C#, it enables:

- Structured and readable test cases
- Annotations for setup, teardown, and test execution
- Parallel execution support
- Easy integration with reporting tools (Allure)

This combination is ideal for building scalable and maintainable web automation frameworks.

# Technologies Used

- Selenium WebDriver
- C# (.NET)
- NUnit Framework
- Visual Studio
- ChromeDriver
- Allure Report 

# How to Run This Project

- Clone the repository
- git clone <repository-url>
- Open the solution
- Open the .sln file in Visual Studio
- Restore dependencies
- NuGet packages will restore automatically
(or use ```dotnet restore```)
- Run tests From Visual Studio Test Explorer
OR
```dotnet test```

# Test Scenario
Website: https://www.daraz.com.bd/

# Automated Flow:

- Navigate to Daraz homepage
- Change site language from English → Bangla
- Verify that the language is updated successfully
- Change site language from Bangla → English
- Verify that the language is updated successfully
- Register a new user account
- Log in using the registered account
- Select a product category
- Select a product from that category and add to cart
- Select a different product category
- Select another product and add to cart
- Proceed to Checkout
- Proceed to Pay / Place Order

# Test Case Checklist

- Verify Daraz homepage loads successfully
- Verify language can be changed from English to Bangla
- Verify language can be changed back from Bangla to English
- Verify user registration works with valid information
- Verify login works with registered credentials
- Verify user can select a product category
- Verify user can add a product to the cart
- Verify user can add products from multiple categories
- Verify cart contains selected products
- Verify user can proceed to checkout
- Verify user can proceed to buy/place order
