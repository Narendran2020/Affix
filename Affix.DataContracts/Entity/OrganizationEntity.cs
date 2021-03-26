using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Affix.DataContracts.Entity
{
    [Table("OrganizationMaster")]
    public sealed class OrganizationEntity : BaseEntity
    {
        [Key] [Column("CompanyID")] public int Id { get; set; }
        [Column("CompanyName")] public string CompanyName { get; set; }
        [Column("CompanyRegNo")] public string CompanyRegNo { get; set; }
        [Column("Address")] public string Address { get; set; }
        [Column("Street")] public string Street { get; set; }
        [Column("Country")] public string Country { get; set; }
        [Column("State")] public string State { get; set; }
        [Column("PhoneNo")] public string PhoneNo { get; set; }
        [Column("Email")] public string Email { get; set; }
        [Column("Website")] public string Website { get; set; }
        [Column("TaxID")] public string TaxId { get; set; }
        [Column("Currency")] public decimal Currency { get; set; }
        [Column("ParentCompany")] public string ParentCompany { get; set; }
        [Column("OrganizationGuid")] public Guid OrganizationGuid { get; set; }
        [Column("FileUpload")] public string FileUpload { get; set; }
        [Column("CreatedBy")] public int? CreatedBy { get; set; }
        [Column("ModifiedBy")] public int? ModifiedBy { get; set; }
      // [Column("Active")] public bool Active { get; set; }
    }
}
