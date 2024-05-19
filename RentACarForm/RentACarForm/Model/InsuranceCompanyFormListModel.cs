using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarForm.Model
{
    internal class InsuranceCompanyFormListModel
    {
        public int InsuranceCompanyFormId { get; set; }
        public string CompanyName { get; set; }
        public decimal? OverDayWage { get; set;}
    }
}
