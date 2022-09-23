using DS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Data.Entity
{
    public class User
    {
        public string? FullName { get; set; }
        public string? TaxCode { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive  { get; set; }
        public ICollection<Singer>? Singers { get; set; }
        public ICollection<InitialDetail>? InitialDetails { get; set; }
        public ICollection<HsmInformation>? HsmInformation { get; set; }
    }
}
