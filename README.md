#COSTA RICA AMIGOS#
![Costa Rica flag]( https://www.crwflags.com/fotw/images/c/cr.gif)


This web app is catered to the fictious �Costa Rica Amigos� tour guide company to list their services using [CRUD operations](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete).


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
-    **Park** is a location and has properties such as:  
    -   Park name, e.g. "Arena National Park"
    -   City, e.g. Jaco (in Costa Rica)
    -   Entrance fee, e.g. $15 USD
    -   An association to the activity in which the park is located

# Architecture

This application will be using .NET core, Entity Frameowrk, C#, Sqlite 


# Prerequisites

## Visual Studio

-Please use Visual Studio

## Desktop

-Please use desktop to get best view

# Start Up

All services can be initialised from the command-line by running the bash script provided within the repository. Please
clone the repository and run commands

```console
git clone https://github.com/Dev-Annie/TravelProject.git

```

This command will sometimes import seed data from the previous on startup.

ADMIN USERNAME: user@email.com
ADMIN PASSWORD: Password123!

Or you could make your own, but it would be for a new tour guide user!


# How does this app utilize CRUD?

The four functions this app is built on is **Create**, **Read**, **Update** and **Delete** 

# Next steps

This MVC can be updated to have multiple prices per adult/ group/ child.  
Better mobile responsiveness can allow people to book specific dates from their phone or tablet