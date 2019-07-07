using System;
using System.Collections.Generic;

namespace CCMSApp.API.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public int? TypeId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? DetailCategoryId { get; set; }
        public string Source { get; set; }
        public int CustomerId { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string LabeledTypeOfCustomer { get; set; }
        public bool? IsTryingToRestart { get; set; }
        public bool? IsBlinkingSignal { get; set; }
        public bool? IsDeadSignal { get; set; }
        public bool? IsPowerOff { get; set; }
        public DateTime InformedAt { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }


        public Category Type { get; set; }
        public Category Category { get; set; }
        public Category SubCategory { get; set; }
        public Category DetailCategory { get; set; }
        public User Author { get; set; }
        public User Editor { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Reference> ParentTickets { get; set; }
        public ICollection<Reference> ChildTickets { get; set; }

    }
}