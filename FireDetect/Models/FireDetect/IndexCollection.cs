using System;
using System.Collections.Generic;

namespace FireDetect.AppModels
{
    public class IndexCollection
    {
        public string ApartmentId { get; set; }
        public string BuildingId { get; set; }

        Dictionary<string, List<Index>> _indexs;
        public Dictionary<string, List<Index>> Indexs
        {
            get => _indexs;
            set => _indexs = value;
        }
        //public Dictionary<string, List<Index>> Indexs
        //{
        //    get
        //    {
        //        if (_indexs == null)
        //        {
        //            _indexs = new Dictionary<string, List<Index>>();
        //            var temp = new List<Index>() { new Index { Name = "Temp", Value = 0, Unit = "do C", TimeMeasure = DateTime.Now } };
        //            var gas = new List<Index>() { new Index { Name = "Gas", Value = 0, Unit = "LPG", TimeMeasure = DateTime.Now } };
        //            var humidity = new List<Index>() { new Index { Name = "Humidity", Value = 0, Unit = "%", TimeMeasure = DateTime.Now } };
        //            var smoke = new List<Index>() { new Index { Name = "Smoke", Value = 0, Unit = "Kg", TimeMeasure = DateTime.Now } };
        //            _indexs.Add("Temp", temp);
        //            _indexs.Add("Gas", gas);
        //            _indexs.Add("Humidity", humidity);
        //            _indexs.Add("Smoke", smoke);
        //        }
        //        return _indexs;
        //    }
        //    set
        //    {
        //        _indexs = value;
        //    }
        //}
    }
}
