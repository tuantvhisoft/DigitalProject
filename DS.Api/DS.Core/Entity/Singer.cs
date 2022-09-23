using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Data.Entity
{
    public class Singer
    {
        public int SingerId { get; set; }
        public int InitialSignerId { get; set; }
        public int DocumentId { get; set; }
        public string UserId { get; set; }
        public string? Status { get; set; }
        public float InWidth { get; set; }
        public float InHeight { get; set; }
        public float InXsignPos { get; set; }
        public float InYsignPos { get; set; }
    }
}
