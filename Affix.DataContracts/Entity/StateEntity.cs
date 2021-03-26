using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Affix.DataContracts.Entity
{
    [Table("StateMaster")]
    public sealed class StateEntity : BaseEntity
    {
        [Key] [Column("StateID")] public int Id { get; set; }
        [Column("State")] public string State { get; set; }

//foreign key reference//
        public CountryEntity Country { get; set; }
        [Column("CountryID")] public int CountryId { get; set; }
        [Column("StateGuid")] public Guid StateGuid { get; set; }
        [Column("CreatedBy")] public int? CreatedBy { get; set; }

        [Column("ModifiedBy")] public int? ModifiedBy { get; set; }
    }
}
