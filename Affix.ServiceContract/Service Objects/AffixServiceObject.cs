using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.ServiceContract.Service_Objects
{
     public sealed class AffixServiceObject
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public bool EnablePrefix { get; set; }
        public string Suffix { get; set; }
        public bool EnableSuffix { get; set; }
        public string Month { get; set; }
        public bool EnableMonth { get; set; }
        public string Year { get; set; }
        public bool EnableYear { get; set; }
        public int CatalogueID { get; set; }
        public CatalogueServiceObject RequiredFor { get; set; } 
        public Guid AffixGuid { get; set; }
        //public int? CreatedBy { get; set; }
        //public int? ModifiedBy { get; set; }
    }
}
