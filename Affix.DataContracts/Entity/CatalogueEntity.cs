using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Affix.DataContracts.Entity
{
    [Table("CatalogueMaster")]
    public sealed class CatalogueEntity : BaseEntity
    {
        [Key] [Column("CatalogueID")] public int Id { get; set; }
        [Column("Catalogue")] public string Catalogue { get; set; }

        [Column("CatalogueGuid")] public Guid CatalogueGuid { get; set; }
        [Column("FacilityID")] public int FacilityID { get; set; }
        [Column("RegulatoryID")] public int RegulatoryID { get; set; }

        [Column("CreatedBy")] public int? CreatedBy { get; set; }

        [Column("ModifiedBy")] public int? ModifiedBy { get; set; }

        //[Column("Status")] public bool status { get; set; }




    }
}
