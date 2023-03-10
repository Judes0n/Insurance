using Insurance.Models;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Services
{
    public class UserService
    {   
        InsuranceDbContext _context;
        public UserService()
        {
            _context=new InsuranceDbContext();
        }
        public User? GetUser(String userName)
        {
            var validUser = _context.Users.Where(u => u.UserName == userName).FirstOrDefault();
            return validUser;
        }

        public User AddUser(User user)
        {   
            _context.Users.Add(user);
            _context.SaveChangesAsync();
            return user;
        }
    }
}
