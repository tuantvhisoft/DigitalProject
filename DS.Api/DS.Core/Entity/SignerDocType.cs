using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class SignerDocType
    {
        public int SignerDocTypeId { get; set; }
        public string? UserId { get; set; }
        public int DocumentTypeId { get; set; }
        public string? Description { get; set; }
        public User? User { get; set; }
        public DocumentType? DocumentType { get; set; }
    }
}
