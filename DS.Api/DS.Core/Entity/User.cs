using DS.Core.Entity;
using Microsoft.AspNetCore.Identity;

namespace DS.Core.Entity
{
    public class User : IdentityUser<string>
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
