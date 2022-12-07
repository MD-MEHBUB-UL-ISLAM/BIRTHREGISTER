using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<User, string, User> , IAuth
    {
        public User Add(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string BirthRegistrationNumber)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(string BirthRegistrationNumber)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
        public User Authenticate(string uname, string pass)
        {
            return null;
        }
    }
}
