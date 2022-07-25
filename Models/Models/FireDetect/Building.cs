using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDetect.Models
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

        List<Apartment> _apartments;
        public List<Apartment> Apartments
        {
            get
            {
                if(_apartments == null)
                {
                    _apartments = new List<Apartment>();
                }
                return _apartments;
            }
            set
            {
                _apartments = value;
            }
        }

        [DisplayName("Số căn hộ")]
        [Display(AutoGenerateField = true)]
        public int NoApartments
        {
            get
            {
                return _apartments.Count();
            }
        }
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
