using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.ViewModel.VModel.User
{
    public class UserViewModel
    {
        public string? FullName { get; set; }
        public string? TaxCode { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string? AccessKey { get; set; }
        public string? SecretKey { get; set; }

    }
}
