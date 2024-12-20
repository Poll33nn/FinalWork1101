using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Data;
using ServiceLayer.Models;

namespace ServiceLayer.Services
{
    public class UserService
    {
        private readonly ShopContext _context = new();


        public async Task<User?> GetUserNameByLogin(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(u  => u.Login == login);
        }
        public async Task<bool> IsUserExist(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == login && u.Password == password);
            if (user == null)
                return false;

            return true;
        }
    }
}
