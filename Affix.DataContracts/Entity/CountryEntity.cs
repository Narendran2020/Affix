using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Affix.DataContracts.Entity
{
    [Table("CountryMaster")]
     public sealed class CountryEntity : BaseEntity
    {
        [Key] [Column("CountryID")] public int Id { get; set; }
        [Column("Country")] public string Country { get; set; }

        [Column("CountryCode")] public string CountryCode { get; set; }
        [Column("CountryGuid")] public Guid CountryGuid { get; set; }
        [Column("CreatedBy")] public int? CreatedBy { get; set; }

        [Column("ModifiedBy")] public int? ModifiedBy { get; set; }




    }
}
