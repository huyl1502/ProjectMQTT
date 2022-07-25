using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vst.Server.Data;

namespace FireDetect.Controllers
{
    class SimulationController : BaseController
    {
        public object Start()
        {
            var lstApartments = FireDetectionDb.Apartments.ToList<Models.Apartment>();
            return Response(lstApartments);
        }
    }
}
