This is made with very simple database - only 1 table named 'Post'.
It has Id, Title, Description, DateCreated.

Inside the Web App we have three methods in the class Database:
1. GetAllPosts - returns list of all posts.
2. AddPost - it makes a dto for post, then it maps it through the dependency injection and add it to the database.
3. DeletePost - when you type the Id of the post the method searches for it and then you have confirmation if the operation is successful.

Thats all for now.
As I learn MVC I will add user profiles with different privileges for post editing.
