using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.ServiceContract.Service_Objects
{
    public sealed class StateServiceObject
    {
        public int Id { get; set; }
        public string State { get; set; }
        // foreign key reference//
        public CountryServiceObject Country { get; set; }

        public int CountryId { get; set; }
        public Guid StateGuid { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        //public CountryServiceObject Country { get; set; }


    }
}
