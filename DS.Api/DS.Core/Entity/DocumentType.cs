using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string? DocumentTypeName { get; set; }
        public string? Temple { get; set; }
        public ICollection<SignerDocType>? SignerDocTypes { get; set; }
        public ICollection<Document>? Document { get; set; }

    }
}
