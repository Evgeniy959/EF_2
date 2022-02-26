using System;
using System.Data.Entity;
using System.Linq;

namespace EF_2
{
    public class LoginPass : DbContext
    {
        // Your context has been configured to use a 'LoginPass' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EF_2.LoginPass' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LoginPass' 
        // connection string in the application configuration file.
        public LoginPass()
            : base("name=LoginPass")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Users> UsersTable { get; set; }
    }

    public class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
    }
}