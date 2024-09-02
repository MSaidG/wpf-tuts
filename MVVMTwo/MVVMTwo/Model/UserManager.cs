using System.Collections.ObjectModel;

namespace MVVMTwo.Model
{
    internal class UserManager
    {
        public static ObservableCollection<User> DatabaseUser =
        [
            new() { Email = "quam@aol.couk", Name = "Erich Fry" }, 
            new() { Email = "in@yahoo.com", Name = "Virginia Salas" }, 
            new() { Email = "luctus@google.com", Name = "Alvin Velasquez" }, 
            new() { Email = "etiam.bibendum@hotmail.edu", Name = "Zia Hutchinson" }, 
            new() { Email = "augue.porttitor@protonmail.org", Name = "Justin Burch" }
        ];

        public static ObservableCollection<User> GetUsers()
        {
            return DatabaseUser;
        }

        public static void AddUser(User user)
        {
            DatabaseUser.Add(user);
        }
    }
}
