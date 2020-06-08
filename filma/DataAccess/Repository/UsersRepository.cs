using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class UsersRepository
    {
        private readonly ApplicationDbContext _context;

        public UsersRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
    }
}
