using HumanResourcesSystem.Business.KpsServiceReference;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
           return client.TCKimlikNoDogrula(Convert.ToInt64(user.TckNo),user.FirstName.ToUpper(),user.LastName.ToUpper(),user.BirthDate.Year);
        }
    }
}
