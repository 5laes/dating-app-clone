
# Dating App Clone

This is a project for me to sharpen my angular skills and learn about implementing live communication between users, role based user authentication, tracking user status, working with images and more.

I wish I could publish this app to some publisher service but I am no economical situation where I can spend the tiniest amount of money right now. If you want to try this app you could clone this repository and build and run it your self. (You will not see any pictures since they are hosted on my API key for Cloudinary)

## How to Build and Run
Tools you need installed
- .NET 9
- Angular 18

I would recommend cloning the ``` 72386c9c4a9e1dcc75ecc454f24b80fae29dcb13 ``` commit since that is the last commit before switching to PostgreSQL from Sqlite.

in one terminal cd in to the API folder and run 
- ``` dotnet restore ```
- ``` dotnet run ```

in another terminal cd in to the client folder and run (both terminals needs to run at the same time)
- ``` npm install ```
- ``` ng serve ```

you should now be able to test this application by connecting to https://localhost:4200


## Features

- Role based authentication using .NET identity
- Live messaging between users using SignalR
- Caches data to reduce database calls
- Users gets notified when they get a message by SignalR
- Users can upload photos that gets stored in a Cloudinary database
- Pagination to only get a certain amount of users at a time to reduce loading time
- Users data is secured using .NET Identity
- The api tracks when a user is online and displays that in the front end with help from SignalR
- Users gets authenticated with JWT 
- and more
## Tech Stack

**Client:** Angular, BootstrapCSS, Cloudinary

**Server:** ASP.NET, C#, Sqlite, PostgreSQl, Entity Framework, SignalR

