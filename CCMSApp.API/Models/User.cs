using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCMSApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Loginname { get; set; }
        public string Directorate { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public int? MemberOf { get; set; }
        public int? Superior { get; set; }
        public bool SpecialPermission { get; set; }
        public bool IsDisabled { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }


        public User GroupMembership { get; set; }
        public User Manager { get; set; }
        public User Author { get; set; }
        public User Editor { get; set; }
        public ICollection<Ticket> TicketsCreated { get; set; }
        public ICollection<Ticket> TicketsModified { get; set; }
        public ICollection<Reference> ReferencesCreated { get; set; }
        public ICollection<Reference> ReferencesModified { get; set; }
        public ICollection<Category> CategoriesCreated { get; set; }
        public ICollection<Category> CategoriesModified { get; set; }
        public ICollection<Customer> CustomersCreated { get; set; }
        public ICollection<Customer> CustomersModified { get; set; }

    }
}