//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Children_information
    {
        public string ChildrenName { get; set; }
        public string Dateofbirth { get; set; }
        public int BirthRegistrationNumber { get; set; }
        public string placeofbirth { get; set; }
        public string FatherNmae { get; set; }
        public string MotherName { get; set; }
        public string parmanentAddress { get; set; }
        public string FatherNationality { get; set; }
        public string MotherNationality { get; set; }
    
        public virtual Hosital_information Hosital_information { get; set; }
    }
}