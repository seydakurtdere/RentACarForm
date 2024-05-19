using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarForm.Model
{
    internal class CustomerFormListModel
    {
        public int CustomerFormId { get; set; }
        public string CustomerName { get; set;}
        public DateTime? CustomerBirthday { get; set;}
        public string CustomerIdentityNumber { get; set;}
        public string CustomerFatherName { get; set;}
        public string CustomerMotherName { get; set;}
        public string CustomerJob { get; set;}
        public string CustomerDrivingLicenceType { get; set;}
        public string CreateByUser { get; set; }
    }
}
