using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class ExternalSigner
    {
        public int ExternalSignerId { get; set; }
        public int DocumentID { get; set; }
        public string? Mail { get; set; }
        public string? CerNo { get; set; }
        public DateTime? ValidDate { get; set; }
        public float ExWidth { get; set; }
        public float ExHeight { get; set; }
        public float ExXsignPos { get; set; }
        public float ExYsignPos { get; set; }
    }
}
