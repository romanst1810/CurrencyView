using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CurrencyView.Models
{
    [DataContract]
    public class CurrencyRate
    {
        [DataMember]
        public DateTime Timestamp { get; set; }
        [DataMember]
        public decimal Rate { get; set; }
    }
}