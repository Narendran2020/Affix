using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.ServiceContract.Service_Objects
{
    public sealed class CatalogueServiceObject
    {
        public int Id { get; set; }
        public string Catalogue { get; set; }

        public Guid CatalogueGuid { get; set; }
        public int FacilityID { get; set; }
        public int RegulatoryID { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
