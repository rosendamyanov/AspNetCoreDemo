using AspNetCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Tests
{
    public class TestHelper
    {
        public static Beer GetTestBeer()
        {
            return new Beer
            {
                Id = 1,
                Name = "Beer1",
                Abv = 4.5,
                StyleId = 1,
                Style = new Style { Id = 1, Name = "IPA" },
                UserId = 1,
                User = new User { Id = 1, Username = "User1" },
                Ratings = new List<Rating>
                {
                    new Rating { Id = 1, Value = 5, UserId = 1, User = new User { Id = 1, Username = "User1" } }
                }
            };
        }

        public static Beer GetCreateTestBeer()
        {
            return new Beer
            {
                Name = "Beer4",
                Abv = 4.5,
                StyleId = 1,
                Style = new Style { Id = 1, Name = "IPA" },
            };
        }


        public static User GetTestUserAdmin()
        {
            return new User
            {
                Id = 1,
                Username = "Test1",
                Password = "Password1",
                FirstName = "Test1",
                LastName = "Test1",
                Email = "Test@mail.com",
                IsAdmin = true,
            };
        }        
        public static User GetTestUser()
        {
            return new User
            {
                Id = 3,
                Username = "Test2",
                Password = "Password2",
                FirstName = "Test2",
                LastName = "Test2",
                Email = "Test2@mail.com",
                IsAdmin = false,
            };
        }
    }
}
