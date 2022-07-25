using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FireDetect.AppModels
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

    public class Time
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
