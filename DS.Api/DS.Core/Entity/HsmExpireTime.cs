using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class HsmExpireTime
    {
        public int HsmExpireTimeId { get; set; }
        public int HsmInId { get; set; }
        public DateTime FromDateGet { get; set; }
        public DateTime ToDateExpire { get; set; }
    }
}
