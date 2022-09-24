using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Core.Entity
{
    public class Document
    {
        public int DocID { get; set; }
        public int StatusID { get; set; }
        public int DocumenTypeId { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Author { get; set; }
        public string? NameFile { get; set; }
        public string? FileExtension { get; set; }
        public bool IsInternal { get; set; }
    }
}
