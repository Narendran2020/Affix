using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Affix.DataContracts.Entity
{
    [Table("AffixMaster")]
    public sealed class AffixEntity : BaseEntity
    {
        [Key] [Column("AffixID")] public int Id { get; set; }

        [Column("Prefix")] public string Prefix { get; set; }
        [Column("EnablePrefix")] public bool EnablePrefix { get; set; }
        [Column("Suffix")] public string Suffix { get; set; }
        [Column("EnableSuffix")] public bool EnableSuffix { get; set; }
        [Column("Month")] public string Month { get; set; }
        [Column("EnableMonth")] public bool EnableMonth { get; set; }
        [Column("Year")] public string Year { get; set; }
        [Column("EnableYear")] public bool EnableYear { get; set; }

        [Column("StartWith")] public int StartWith { get; set; }

        [Column("CatalogueID")] public int CatalogueID { get; set; }
        public CatalogueEntity RequiredFor { get; set; }
        [Column("AffixGuid")] public Guid AffixGuid { get; set; }

        // CreatedDate and MOdifiedDate is already in BaseEntity//
       // [Column("CreatedBy")] public int? CreatedBy { get; set; }
        //[Column("ModifiedBy")] public int? ModifiedBy { get; set; }
        //[Column("Status")] public bool status { get; set; }







    }
}
