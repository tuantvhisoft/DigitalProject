﻿using DS.Core.Entity;
using Microsoft.AspNetCore.Identity;

namespace DS.Core.Entity
{
    public class User : BaseEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? TaxCode { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive  { get; set; }
        public string? AccessKey { get; set; }
        public string? SecretKey { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public bool IsBlocked { get; set; }
        public ICollection<Signer>? Signers { get; set; }
        public ICollection<InitialDetail>? InitialDetails { get; set; }
        public ICollection<HsmInformation>? HsmInformation { get; set; }
        public ICollection<SignerDocType>? SignerDocTypes { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; } = new List<UserRole>();
        public ICollection<UserLoginToken>? UserLoginTokens { get; set; } = new List<UserLoginToken>();

    }
}
