# DIploma_testRail

## About the project.

This project was written after completing a C# test automation course as a final assignment. The framework of this repository allows you to run and create automated tests for the Testrail site.
The diploma uses various approaches to code design and various additional libraries. Also, some test scenarios for working with objects have already been developed in the diploma: "test project", "test case".
For convenient use by any user, the data is placed in the settings file.

### How to start 

To get started, you need download the project and nugets package and to create an account
at https://secure.testrail.com/customers/testrail/trial/?type=signup&

After that, in the settings of the created project, open access for api and create an api token.

the created data must be registered in apsetting also update some IDs in the variables of the test objects

### Used libriary 

Nunit 

NUnit.Allure.Attributes;  

OpenQA.Selenium.Chrome;  

OpenQA.Selenium.Interactions; 

Microsoft.Extensions.Configuration; 

RestSharp; 

RestSharp.Authenticators; 

Newtonsoft.Json; 

NLog;

### Test scenaries
#### API tests

***GetRuns***  - Get all test runs from project by code project

***InvalidToken***  - get error unauthorized

***GetTestCase***  - Get all information about test case by code

***CreateTestCase*** - create test case with random content  by code test cases

***DeleteTestCase*** - delete test case  by code test cases

***UpdateTestCase*** - update test case with random content by code test cases

***GetProject***  - get all information about project by code projects

***GetProjects***  - get information about all projects on account

***AddProjects***  -   create project with random content 

***UpdateProject*** - update project with random content by code projects

***DeleteProject***  - delete project by code projects


#### UI tests

***GoodLogin***   - login and assert info about account in UI

***CreateProject***  - create project with random content in UI

***EditProject*** - edit existing project with random content in UI

***DeleteProject*** -  delete existing project in UI

***CreateTestCase***  -  create test case in existing project in UI

***DeleteTestCase*** - delete test case in existing project in U
