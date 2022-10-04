using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class Signer
    {
        public int SignerId { get; set; }
        public int InitialSignerId { get; set; }
        public int DocumentId { get; set; }
        public Guid UserId { get; set; }
        public string? Status { get; set; }
        public float InWidth { get; set; }
        public float InHeight { get; set; }
        public float InXsignPos { get; set; }
        public float InYsignPos { get; set; }
        public User? User { get; set; }
        public Document? Document { get; set; }
        public InitialSigner? InitialSigner { get; set; }
    }
}
