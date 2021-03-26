using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.ServiceContract.Service_Objects
{
    public sealed  class CountryServiceObject
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public Guid CountryGuid { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

    }
}
