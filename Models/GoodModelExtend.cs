using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace REST_P2.Models
{
    [MetadataType(typeof(GoodExtends))]
    public partial class Good
    {

    }
    public partial class GoodExtends
    {
       
       [JsonIgnore]
        public virtual ICollection<SaleItem> SaleItem { get; set; }
    }
}