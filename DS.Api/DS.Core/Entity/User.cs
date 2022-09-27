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
        public ICollection<Signer>? Signers { get; set; }
        public ICollection<InitialDetail>? InitialDetails { get; set; }
        public ICollection<HsmInformation>? HsmInformation { get; set; }
        public ICollection<SignerDocType>? SignerDocTypes { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; } = new List<UserRole>();
        public ICollection<UserLoginToken>? UserLoginTokens { get; set; } = new List<UserLoginToken>();

    }
}
