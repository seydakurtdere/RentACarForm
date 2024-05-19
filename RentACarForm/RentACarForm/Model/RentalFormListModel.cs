using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarForm.Model
{
    internal class RentalFormListModel
    {
        public int rentalformID { get; set; }
        public string CustomerName { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int? CarYear { get; set; }
        public string CompanyName { get; set; }
        public decimal? OverDayWage { get; set; }
        public decimal? DailyWage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Date { get; set; }

    }
}