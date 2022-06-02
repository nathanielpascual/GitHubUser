Installation
1.) You must have .net framework 4.8
2.) download the files in your local and run


1.) I used Unity as IOC for the dependency injections
2.) I used webclient for managing the api.
3.) I added DTO Models User, UserDetails, Owner and License and a ViewModel UserViewModel to Encapsulate the DTOs.
4.) I added UserRepository and UserDetailRepository
5.) I added UserService to encapsulate the data access layers.

Using Dependency Injection
 - IUserRepository,UserRepository
 - IUserDetailRepository, UserDetailRepository
 - IUserServices,  UserServices

 MVC Architecture
 -Presentation Layer (HTML &  Controller)
 --Services
 ---Business Models
 ----Repository
 -----Models (DTO)
 ------API

 Process
 1.Initial reading I set "InitialEntry" to be catch by the userservice and return a blank userviewmodel
 2.if you entered space, it will throw an error.
 3.if you entered a name not in the git's user list, it will throw invalid user.
 4.if you entered a name with an error in its repos, it will throw a custom error.
 5.if the user has no  repos, it will throw a no repo error but it will display its profile.