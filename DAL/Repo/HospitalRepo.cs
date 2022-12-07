using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL.Repo
{
    class HospitalRepo : IRepo<Children_information, int, Children_information>
    

      



    {
        Registration_Birth_cirtificateEntities db;


        internal HospitalRepo()
        {
            db = new Registration_Birth_cirtificateEntities();              
        }




        public Children_information Add(Children_information obj)
        {
            db.Children_information.Add(obj);   
            db.SaveChanges();
            return obj;
        }

        public Children_information Authenticate(string uname, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int BirthRegistrationNumber)
        {
            db.Children_information.Remove(db.Children_information.Find(BirthRegistrationNumber));
            db.SaveChanges();
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
            var ext = db.Children_information.Find(obj.BirthRegistrationNumber);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges()> 0;
        }
    }
}
