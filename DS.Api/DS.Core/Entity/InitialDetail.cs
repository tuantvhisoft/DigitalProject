using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Data.Entity
{
    public class InitialDetail
    {
        public int InitialDetialId { get; set; }
        public int InitialId { get; set; }
        public string UserId { get; set; }
        public string? Message { get; set; }
        public string? DetailStatus { get; set; }
    }
}
