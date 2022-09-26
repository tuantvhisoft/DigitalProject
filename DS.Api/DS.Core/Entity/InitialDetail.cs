using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class InitialDetail
    {
        public int InitialDetailId { get; set; }
        public int InitialSignerId { get; set; }
        public string? UserId { get; set; }
        public string? Message { get; set; }
        public string? DetailStatus { get; set; }
        public User? User { get; set; }
        public InitialSigner? InitialSigner { get; set; }

    }
}
