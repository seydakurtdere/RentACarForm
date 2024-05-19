using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarForm.Infrastructure
{
    public static class LoginUser
    {
        public static AppUserForm AppUser { get; set; }



        /// <summary>
        /// AppUser nesnesi parametreden gelen yeni appuser nesnesi ile güncellenir.
        /// </summary>
        /// <param name="appUserForm">AppUserForm datası</param>
        public static void SetAppUser(AppUserForm appUserForm)
        {
            AppUser = appUserForm;
        }

        /// <summary>
        /// Güncelde olan AppUser nesnesini döndürür
        /// </summary>
        /// <returns> AppUser nesnesi</returns>
        public static AppUserForm GetAppUserForm()
        {
            return AppUser;
        }
    }
}
