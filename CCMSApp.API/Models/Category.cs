using System;
using System.Collections.Generic;

namespace CCMSApp.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int? ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }


        public Category ParentCategory { get; set; }
        public User Author { get; set; }
        public User Editor { get; set; }
        public ICollection<Ticket> TicketType { get; set; }
        public ICollection<Ticket> TicketCategory { get; set; }
        public ICollection<Ticket> TicketSubCategory { get; set; }
        public ICollection<Ticket> TicketDetailCategory { get; set; }

    }
}