using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.ServiceContract.Service_Objects
{
    public sealed class OrganizationServiceObject
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyRegNo { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string TaxId { get; set; }
        public decimal Currency { get; set; }
        public string ParentCompany { get; set; }
        public string FileUpload { get; set; }
        public Guid OrganizationGuid { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }








    }
}
