using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Affix.DataContracts.Entity
{
    public abstract class BaseEntity
    {
        
        
        [Column("ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        [Column("CreatedDate")]

        public DateTime CreatedDate { get; set; }

        [Column("Status")]

        public bool Status { get; set; }





    }
}
