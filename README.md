# Hair Salon

#### _Week 3 solo project C#, 06.09.2017_

#### By _**Pete Lazuran**_

## Description

This app will allow a salon owner to keep track of their employees and each individual employee's clientele.


|Behavior|User Input|Expected Output|
|---------|----------|-----------|
|User clicks on a hypertexted word it takes them to the appropriate page|Click on "add a stylist"|Program loads "/stylist/add"|
|User fills out the form to add a stylist and clicks submit, program saves the input to the database|"Stephanie"|"Stephanie" and all other entered stylists now display in the list of stylists|
|Program can pull all names from a table for display as a list|Click on "View all stylists"|"Stephanie", "Maxine", "Dolly"|
|Clicking on a stylist's name will load a page of all their clients|User clicks on "Stephanie"|Program loads "/stylist/{id}" with all clients of that stylist listed|
|User fills out the form to add a client to a particular stylist and clicks submit, program saves the input to the database|User types "Sandra" into the input field and selects "Stephanie" as her stylist from the drop down list|"Sandra" and all other clients of Stephanie now display in her list of clients|
|Clients names are editable|User clicks **edit** next to the client name "Sandra". In the input field user types "Sandra Boos"|Database entry for "Sandra" is patched to be "Sandra Boos"|
|Clients can be deleted from the database|User clicks **delete** next to the client name "Sandra Boos", is taken to a caution page. Then clicks "delete" button|Database entry for "Sandra Boos" is deleted|

## Setup/Installation Requirements
##### (Instructions written for a PC using PowerShell with Mono, ASP.Net 5, and Microsoft SQL server management studio installed)

* Open Terminal.
* Clone this repository.
* Navigate to the file directory in terminal (..\Desktop\RepeatCounter>).
* Open in a text editor if you wish to view the code.
* To view the site in your local server enter the command "dnx kestrel" in your Terminal.

* **To recreate the database used in this project by scratch in your powershell you must enter the following commands:**
* _sqlcmd -S "(localdb)\mssqllocaldb"_
* _GO_ (at this point your file path should change to "1>", denoting that you have accessed your database)
*  _CREATE DATABASE_ hair_salon;
* _GO_
* _CREATE TABLE stylists (name VARCHAR(255), id INT IDENTITY(1,1))_
* _GO_
* _CREATE TABLE clients (name VARCHAR(255)_, stylist_id _INT, id INT IDENTITY(1,1))_
* _GO_


## Known Bugs

None

## Support and contact details

Direct all questions and comments to pdlazuran@gmail.com

## Technologies Used

C#, HTML, Nancy, Razor, Xunit, PowerShell, MSSQL server management studio 2017.

### License

*MIT*

Copyright (c) 2017 **_Pete Lazuran_**






## Specs

* Create a database named hair_salon with tables named stylist and client. Test that the database is empty. This ensures the database has been initialized correctly.

* In stylists class give stylists a name, and id. Test that the constructor works. This will ensure that the stylists class is working as intended.

* Create a GetAll() method that will be used to display all stylists. Test that a list is being created correctly. This will enable the salon owner to view all of their stylists.

* Create a method to add new stylists to the database. Test that the Save() method works. This will allow to find errors in the database table/class relationship and allow the salon owner to add new stylists to their salon.

* Create a client class and give clients a name, id and stylist id. Test that the constructor works. Ensuring the new class is working as intended and allowing the clients to be assigned to a single stylist via the stylist id as per the requirements of the salon owner.

* Create a method to add new clients to a stylist. Test that the Save() method works for clients. Fulfills the salon owners wish for a way to add new clients.

* Create a method that will pull all clients of a particular stylist id from the database. Test that this method works. This will be used to show all of one stylists clients.

* Create an update method for class client to allow the user to update a client's name.

* Create a delete function to allow the user to remove a client from their salon.
