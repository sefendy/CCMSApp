using System;

namespace CCMSApp.API.Models
{
    public class Reference
    {
        public int ParentTicketId { get; set; } 
        public int ChildTicketId { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }


        public User Author { get; set; }
        public User Editor { get; set; }
        public Ticket ParentTicket { get; set; }  
        public Ticket ChildTicket { get; set; }

    }
}