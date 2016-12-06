# GamesDB
An MVVM style Universal Windows Platform (UWP) application that queries an external API, created as part of the Mobile Applications Development module in BSc.Programming in Software Development (Honours), Galway-Mayo Institute of Technoloy.

## Project motivation
The reason I created this application was to learn more about MVVM. I can safely say I've grasped the concept but in terms of implementing it, I've only just scratched the surface.

## Project description
The project is a single page application built on the UWP system. The application is used to query information about games, that is stored on a remote database, using an API. The data I used was from the Internet Game Database, link here: <https://www.igdb.com/>.

## Using the application
Upon entering the app, the users focus will be drawn to a text box near the top of the screen, where they will have to enter a name for a game to search. Once a search query is written, the user can either hit the return key "ENTER", or click the Search button at the top of the screen to query the database. The database returns 10 game objects that, when clicked, will open up another table to display more information. At the bottom of the page are buttons to navigate pages. Because there is a limit to how many entries I can retrieve from the IGDB, the page number needed is unknown until the user reaches the end, and the Next button becomes disabled.

## Running the application locally
To run this application locally, the user needs to have:
* Visual Studio 15 or above
* Windows 10 (10.0; Build 10240) or above

Once the prerequisites are met, simply go into the folder GamesDB and double click the .sln file.
