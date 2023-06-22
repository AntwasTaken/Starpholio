using Starpholio.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Starpholio.Models

    
{
    public class LoginSys
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }


        public bool TwoFactorAuthentication { get; set; }
    }
}


public class AuthService
{
    private readonly StarpholioDB _dbContext;

    public AuthService(StarpholioDB dbContext)
    {
        _dbContext = dbContext;
    }

    public bool Login(string username, string password)
    {
        // Retrieve the user from the database based on the username
        var user = _dbContext.Users.FirstOrDefault(u => u.Username == username);

        if (user != null)
        {
            // Verify the password
            if (user.Password == password)
            {
                // User is authenticated, perform additional operations if needed
                // Return true to indicate successful login
                return true;
            }
        }

        // Return false to indicate unsuccessful login
        return false;
    }
}
