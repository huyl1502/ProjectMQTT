using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDetect.Models
{
    public class Index
    {
        [DisplayName("Chỉ số")]
        [Display(AutoGenerateField = true)]
        public string Name { get; set; }

        [DisplayName("Giá trị")]
        [Display(AutoGenerateField = true)]
        public int Value { get; set; }

        [DisplayName("Đơn vị")]
        [Display(AutoGenerateField = true)]
        public string Unit { get; set; }

        [Display(AutoGenerateField = false)]
        public bool IsWarning { get; set; }

        [DisplayName("Thời gian đo")]
        [Display(AutoGenerateField = true)]
        public DateTime TimeMeasure { get; set; }
    }
}
