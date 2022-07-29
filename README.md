#COSTA RICA AMIGOS

![Costa Rica flag]( https://www.crwflags.com/fotw/images/c/cr.gif)


This web app is catered to the fictious “Costa Rica Amigos” tour guide company to list their services using [CRUD operations](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete).
There is also the added bonus of adding rental properties to the site.  The following details more about the project: 

## Contents

<details>
<summary><strong>Details</strong></summary>

-   [Data Entities](#data-entities)

-   [Architecture](#architecture)
-   [Prerequisites](#prerequisites)
-   [Start Up](#start-up)
-   [What does this CRUD app do?](#How-does-this-app-utilize-CRUD?) 
    -   [Create Operations](#create-operations)
    -   [Read Operations](#read-operations)
    -   [Update Operations](#update-operations)
    -   [Delete Operations](#delete-operations)
-   [Next Steps](#next-steps)

</details>

# Data Entities


Within this basic shopping cart management system there are two entities.   The entity relationships are detailed here: 


-    **Activities** are the events the customer would like to plan and have the following properties: 
    -   Name, e.g. "Zip-lining"
    -   Duration, e.g. "3 hour session"
    -   Price, e.g. $50 USD
-    **Rental** is a location and has properties such as:  
    -   Rental name, e.g. "Arena National Rental"
    -   City, e.g. Jaco (in Costa Rica)
    -   Nightly Fee, e.g. $40/day USD
    -   An association to the activity in which the rental is located

# Architecture

This application will be using .NET core, Entity Framework, C#, Sqlite 

-You must create at least one class, then create at least one object of that class and populate it with data. You must use or display the data in your application.
 Created class Activity with several objects with properties of name and price
 Created class Rentals with several objects with properties of city and fee

-Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application.
Create, Read, Update, Delete method can be seen in Views folder 

-Features List 
1. Visualized data in a table format that shows activities on itinerary page (index)
2. Used several LINQ query to retrieve information from the data structure (SQLite database) to update entries 
3. Added rejex to input fields of Activity Name and Rental City
4. Used several LINQ query to Sort Activities alphabetically




# Prerequisites

## Visual Studio

-Please use Visual Studio

## Desktop

-Please use desktop to get best view

# Start Up

All services can be initialised by cloning the repository
https://localhost:7074/Home/

```console
git clone https://github.com/Dev-Annie/TravelProject.git

```

This command will sometimes import seed data from the previous on startup.

SAMPLE USERNAME: user@user.com
SAMPLE PASSWORD: Code$123

Or you could make your own, but it would be for a new tour guide user!


# How does this app utilize CRUD?

The four functions this app is built on is **Create**, **Read**, **Update** and **Delete** 


# Next steps

This MVC can be updated to have multiple prices per adult/ group/ child.  
Better mobile responsiveness can allow people to book specific dates from their phone or tablet.
A chat option can be added in the future and layout page has been made.
