using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FireDetect.AppModels
{
    public class Building
    {
        [Display(AutoGenerateField = false)]
        public string ID { get; set; }

        [DisplayName("Tên")]
        [Display(AutoGenerateField = true)]
        public string Name { get; set; }

        [DisplayName("Địa chỉ")]
        [Display(AutoGenerateField = true)]
        public string Address { get; set; }

        [DisplayName("Vị trí")]
        [Display(AutoGenerateField = true)]
        public Location Location { get; set; }

        List<string> _apartmentsId;
        [Display(AutoGenerateField = false)]
        public List<string> ApartmentsId
        {
            get
            {
                if (_apartmentsId == null)
                {
                    _apartmentsId = new List<string>();
                }
                return _apartmentsId;
            }
            set
            {
                _apartmentsId = value;
            }
        }

        [DisplayName("Số căn hộ")]
        [Display(AutoGenerateField = true)]
        public int NoApartments { get; set; }

        [Display(AutoGenerateField = false)]
        public int NoFloors { get; set; }
    }

    public class Address
    {
        public string City { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Ward { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;

        public override string ToString()
        {
            return String.Format("{0}, Phường {1}, Quận {2}, Thành phố {3}", Details, Ward, District, City);
        }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
    }
}
