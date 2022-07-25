using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDetect.Controllers;

namespace FireDetection
{
    class Program : Vst.Server.SlaveServer
    {
        static void Main(string[] args)
        {
            BaseController.CreateDb();
            new Program().Start();
        }
    }
}
