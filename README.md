# Mod 2 Week 5 Assessment

Start by Forking this repo.

## Questions (10 Points Possible)

1. In at least two sentences, how would you define what seed data is and why it's useful? (1 point possible)

1. Deleting a database column is a dangerous action, what might happen if you delete a column you didn't mean to? (1 point possible)

1. Write out at least 3 steps to describe the process of adding a new column to your database using entity framework. (1 point possible)

1. When I run `Update-Database`, which function in the migration is used `Up` or `Down`? (1 point possible)

1. When was Entity Framework Core version 7.0 released? As always, feel free to use google as a resource in answering this question. (1 point possible)

1. True or False: When using Entity Framework to create database tables for a many-to-many relationship, you must create a class to represent the join table? Explain your answer. (1 point possible)

1. Replace the ____________s with the code required to create the models required for the following entity relationship diagram. Don't worry about `Routeid` vs `RoutesId` and `Stopid` vs `StopsId`, either is fine. Also, no need to include the `terminus` column. (2 points possible)

<img width="600" alt="Stop and Route ERD" src="https://user-images.githubusercontent.com/11747682/228308854-d2328b8c-32d2-4eb9-aa0d-8a2b3d4c6bfa.png">

```C#
namespace BusTransitApp
    {
        public class Route
        {
            _____________________
        }
    }

namespace BusTransitApp
    {
        public class Stop
        {
            _______________________
        }
    }
```


1. Replace the _______________s with the code required to seed at least two `Route` objects and at least two `Stop` objects based on your models above. Make sure that there is a many-to-many relationship between your data. (2 points possible)

```C#
namespace BusTransitApp.Data
{
    public class DataSeeder
    {
        public static void SeedRoutesAndStops(BusTransitContext context)
        {
            if (______________)
            {
                ______________________________
            }
        }
    }
}
```
## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a project that has already been set up using Entity Framework.

**Goal 1**: Create your concert database without changing the models. You will need to modify the project to include your specific postgress password, then create a migration, then update your database. (3 points possible)

Delivarable: In your slack message to instructors, include a screenshot of the ERD for your concerts table in pgAdmin to show you have completed this step.

**Goal 2**: Add a performers table to your database. Implement a many-to-many relationship between concerts and performers. It's up to you what fields your performers table includes, but it should have at least 3 fields. (6 points possible)

Deliverable: In your slack message to instructors, include a screenshot of the ERD for your concerts and performers tables in pgAdmin to show you have completed this step.

(following instructions is 1point).

## Extra Challenge (0 Points Possible)

Add some seed data for performers and concerts.

## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
* Submit the link to your forked repository in the submission form posted in slack!
