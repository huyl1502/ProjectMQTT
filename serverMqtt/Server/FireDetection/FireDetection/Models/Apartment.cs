using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDetect.Models
{
    public class Apartment
    {
        [Display(AutoGenerateField = false)]
        public string ID { get; set; }

        [Display(AutoGenerateField = false)]
        public int Number { get; set; }

        [DisplayName("Số nhà")]
        [Display(AutoGenerateField = true)]
        public string DisplayNumber
        {
            get
            {
                return String.Format("{0:0}{1:00}", FloorNumber, Number);
            }
        }

        [Display(AutoGenerateField = false)]
        public string BuildingId { get; set; }

        [Display(AutoGenerateField = false)]
        public int FloorNumber { get; set; }

        Resident _owner;
        [Display(AutoGenerateField = false)]
        public Resident Owner
        {
            get
            {
                if (_owner == null)
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

        [DisplayName("Chủ hộ")]
        [Display(AutoGenerateField = true)]
        public string OwnerName
        {
            get => _owner.Name;
        }

        [DisplayName("Số điện thoại")]
        [Display(AutoGenerateField = true)]
        public string OwnerPhoneNumber
        {
            get => _owner.PhoneNumber;
        }
    }
    public class Resident
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
