using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarForm.Model
{
    public class CarsFormListModel
    {
        public int CarsFormId { get; set; }
        //[DisplayName("Marka")] Yazarak isim değişikliği yapılabilir
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int?  CarYear { get; set; }
        public int? CarKm { get; set; }
        public string CarDamagedParts { get; set; }
        public string CreateByUser { get; set; }
    }
}
