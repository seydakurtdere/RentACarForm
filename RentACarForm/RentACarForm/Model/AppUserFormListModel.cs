using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarForm.Model
{
    internal class AppUserFormListModel
    {
        public int AppUserFormId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
