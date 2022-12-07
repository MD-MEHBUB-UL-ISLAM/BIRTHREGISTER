using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class BIRTHREGISTERv2 : IRepo<BIRTHREGISTER, int, bool>
    {
        public bool Add(BIRTHREGISTER obj)
        {
            throw new NotImplementedException();
        }

        public BIRTHREGISTER Authenticate(string uname, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int BirthRegistrationNumber)
        {
            throw new NotImplementedException();
        }

        public List<BIRTHREGISTER> Get()
        {
            throw new NotImplementedException();
        }

        public BIRTHREGISTER Get(int BirthRegistrationNumber)
        {
            throw new NotImplementedException();
        }

        public bool Update(BIRTHREGISTER obj)
        {
            throw new NotImplementedException();
        }
    }
}
