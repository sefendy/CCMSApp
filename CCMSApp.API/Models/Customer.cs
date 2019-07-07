using System;

namespace CCMSApp.API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CircuitId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCategory { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string EndCustomerId { get; set; }
        public string EndCustomerCategory { get; set; }
        public string EndCustomerName { get; set; }
        public string EndCustomerLocationId { get; set; }
        public string EndCustomerAddress { get; set; }
        public string EndCustomerCity { get; set; }
        public string EndCustomerPostalCode { get; set; }
        public string EndCustomerPhoneNumber { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string Pic { get; set; }
        public string PicPhoneNumber { get; set; }
        public string AccountStatus { get; set; }
        public DateTime RegisteredDate { get; set; }
        public DateTime ActivedDate { get; set; }
        public DateTime SuspendedDate { get; set; }
        public DateTime TerminatedDate { get; set; }
        public string RegisteredBy { get; set; }
        public string ActivedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public User Author { get; set; }
        public User Editor { get; set; }


    }
}