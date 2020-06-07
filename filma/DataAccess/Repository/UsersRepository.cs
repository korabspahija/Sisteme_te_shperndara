using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class UsersRepository
    {
        private readonly UsersContext _context;

        public UsersRepository(UsersContext context)
        {
            this._context = context;
        }
    }
}
