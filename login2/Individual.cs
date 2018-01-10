//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Individual
    {
        public Individual()
        {
            this.Companies = new HashSet<Company>();
            this.Employees = new HashSet<Employee>();
            this.IndividualCustomers = new HashSet<IndividualCustomer>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CNP { get; set; }
        public System.DateTime Birthday { get; set; }
    
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<IndividualCustomer> IndividualCustomers { get; set; }
    }
}