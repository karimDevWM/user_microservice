using userMicroservice.Data;
using userMicroservice.Model;

namespace userMicroservice.Tests.Common.ScenarioDatas
{
    public static class UserUtilities
    {
        public static void CreateUser(this DbContextClass dbContextClass)
        {
            var user = new User
            {
                UserId = 1,
                UserName = "JessieDoe",
                Address = "45 cours franklin roosevelt 69120 Vaulx-en-velin"
            };

            dbContextClass.Users.Add(user);
            dbContextClass.SaveChanges();
        }

        public static void CreateUsers(this DbContextClass dbContextClass)
        {
            var user1 = new User
            {
                UserId = 1,
                UserName = "JessicaDoe",
                Address = "45 cours franklin roosevelt 69120 Vaulx-en-velin"
            };

            var user2 = new User
            {
                UserId = 2,
                UserName = "JoeDoe",
                Address = "45 cours franklin roosevelt 69120 Vaulx-en-velin"
            };

            dbContextClass.Users.AddRange(user1, user2);
            dbContextClass.SaveChanges();
        }
    }
}
