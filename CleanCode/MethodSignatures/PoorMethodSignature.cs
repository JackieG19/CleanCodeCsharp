using System;
using System.Linq;

namespace CleanCode
{
  public class PoorMethodSignatures
  {
      public void Run()
      {
          var userService = new UserService();
          var user = new userService.GetUser("username", "password", true);
          var anotherUser = userService.GetUser("username", null, false);
      }
  }
  
  public class UserService
  {
      private UserDbContext _dbContext = new UserDbContext();
      
      public User GetUser(string username, string pasword, bool login)
      {
          if(login)
          {
              // Check if there is a user with the given username and password in db
              // If yes, set the last login date
              // and then return the user
              
              var user = _dbContext.User.SingleOrDefault(u => u.Username == username && u.Password == password);
              if(user != null)
                user.LastLogin = DateTime.Now;
              return user;
          }
          
          else
          {
              // Check if there is a user with given username
              // If yes, return it otherwise return null
              
              var user = _dbContext.User.SingleOrDefault(u => u.Username == username);
              return user;
          }
      }
   }
}
