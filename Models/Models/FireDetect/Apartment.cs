using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDetect.Models
{
    public class Apartment
    {
        public string ID { get; set; }
        public int Number { get; set; }
        public string BuildingId { get; set; }
        public int FloorNumber { get; set; }

        Resident _owner;
        public Resident Owner { 
            get
            {
                if(_owner == null)
                {
                    _owner = new Resident { Name = "", PhoneNumber = "" };
                }
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }
    }
    public class Resident
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
