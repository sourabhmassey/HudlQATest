# Huld QA Test
There are 2 projects 
- HudlTestFrameworks
- HudlClientTests
HudlTestFrameworks is a selenium Nunit framework in C#
HudlClientTests is a collection of tests for the landing page and login page.

I had limited time today due to back to back meetings and then a security issue that had me copy the whole solution manually from my work laptop to personal. That led to the .Net core 6 imcompatibilty issues with .net framework 4.8.1, otherwise i would have added more scenarios. 

load the project with TestProject1.snl and build it, you might have to install the selenium and nunit drivers if not prompted automaticaly.

I have implemented the Page object model and tried to keep the Tests as lite as possible.

You might have require to install following packages, depending on your setup
     "DotNetSeleniumExtras.PageObjects" Version="3.11.0"
     "DotNetSeleniumExtras.PageObjects.Core" Version="4.3.0" 
     "NUnit" Version="3.13.3"
     "NUnit3TestAdapter" Version="4.2.1" 
     "Microsoft.NET.Test.Sdk" Version="17.3.1" 
     "NUnitTestAdapter.WithFramework" Version="2.0.0" 
     "Selenium.Firefox.WebDriver" Version="0.27.0" 
     "Selenium.WebDriver" Version="4.4.0" 
     "WebDriver.ChromeDriver.win32" Version="105.0.5195.52" 
