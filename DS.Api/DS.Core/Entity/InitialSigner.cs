using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class InitialSigner
    {
        public int InitialSignerId { get; set; }
        public string? InSignerStatus { get; set; }
        public Signer? Signer { get; set; }
        public ICollection<InitialDetail>? InitialDetails { get; set; }
    }
}
