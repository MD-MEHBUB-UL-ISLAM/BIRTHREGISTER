using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BIRTHREGISTER : IRepo<Children_information, int, bool>
    {

        Registration_Birth_cirtificateEntities db;


        internal BIRTHREGISTER()
        {
            db = new Registration_Birth_cirtificateEntities();
        }

        public bool Add(Children_information obj)
        {
            db.Children_information.Add(obj); ;
            return db.SaveChanges() > 0;
        }

        public Children_information Authenticate(string uname, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int BirthRegistrationNumber)
        {
            var ext = db.Children_information.Find(BirthRegistrationNumber);
            db.Children_information.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Children_information> Get()
        {
           return db.Children_information.ToList();
        }

        public Children_information Get(int BirthRegistrationNumber)
        {
            return db.Children_information.Find(BirthRegistrationNumber);
        }

        public bool Update(Children_information obj)
        {
            var ext = Get(obj.BirthRegistrationNumber);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;    

        }
    }
}
