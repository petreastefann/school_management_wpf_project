# PROJECT DISCONTINUED DUE TO THE DEVELOPMENT TEAM'S FUNDS RUNNING OUT

### school_management_wpf_project
a project which aims to be a school management app.

### configuration
- (you need to have ssms installed)
- in the project, go into Tools -> NuGet Package Manager -> Package Manager Console
- in the opened console type "Add-Migration (your random migration name here)"
- then in the same console type "Update-Database"
- (because i have no user register you have to insert at least an admin into the users table)
- that's it really.
- it has some bugs such as some unhandled exceptions or the fact that some fields do not change real-time, but its a good start


### roadmap

- [x] login

~~- [ ] register~~
- [x] change windows when succesfully logging in
- [x] move the logged user data to a specific View depending on their role
- [x] do each View
- [x] (ish) do the functionality of the each ViewModel (admin, teacher, user)
- [x] see that database
