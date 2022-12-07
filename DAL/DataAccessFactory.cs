using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL.Repo;
using DAL.EF;
using System.Data.SqlTypes;

namespace DAL
{
    public class DataAccessFactory
    {

        public static IRepo<Children_information, int,bool> GroupDataAccess()
        {
             return new BIRTHREGISTER();
        }
        public static IRepo<Children_information, int , Children_information> Children_informationDataAccess(){
            return new HospitalRepo();
        }
        public static IRepo<User, string, User> UserDataAccess()
        {
            return new UserRepo();

        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();


        }
    } 
}
