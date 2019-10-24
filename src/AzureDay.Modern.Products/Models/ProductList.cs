using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AzureDay.Modern.Products.Models
{
    [DataContract]
    public class ProductList
    {
        [DataMember(Name = "items")]
        public List<string> Items { get; set; }
    }
}
