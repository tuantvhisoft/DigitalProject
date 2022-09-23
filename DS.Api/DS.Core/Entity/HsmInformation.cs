using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class HsmInformation
    {
        public int HsmInId { get; set; }
        public string? UserId { get; set; }
        public string? IdentityCard { get; set; }
        public string TokenHsm { get; set; }
        public ICollection<HsmExpireTime>? HsmExpireTimes { get; set; }
    }
}
