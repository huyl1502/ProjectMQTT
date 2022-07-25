using FireDetect.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDetect.Controllers
{
    class IndexController : BaseController
    {
        public object Manage()
        {
            var context = ServerContext.ParseObject<JObject>();
            var apartmentId = context["ApartmentId"].ToString();
            var indexName = context["IndexName"].ToString();

            var indexCollection = FireDetectionDb.Indexs.Find<IndexCollection>(apartmentId);
            var indexs = indexCollection.Indexs[indexName];
            var rsIndex = new List<Index>();
            var count = indexs.Count() - 1;
            if (count >= 19)
            {
                for (int i = 19; i >= 1; i--)
                {
                    rsIndex.Add(indexs.ToArray()[count - i]);
                }
            }
            else
            {
                foreach(var i in indexs)
                {
                    rsIndex.Add(i);
                }
            }
            //foreach (var item in indexs.Indexs.ToList())
            //{
            //    var rsIndex = new List<Index>();
            //    var lstIndex = (List<Index>)item.Value;
            //    var count = lstIndex.Count() - 1;

            //    if (count >= 19)
            //    {
            //        for (int i = 0; i < 20; i++)
            //        {
            //            rsIndex.Add(lstIndex[count - i]);
            //        }
            //        indexs.Indexs[item.Key] = rsIndex;
            //    }
            //}

            var res = new IndexCollection() {
                ApartmentId = indexCollection.ApartmentId,
                BuildingId = indexCollection.BuildingId,
                Indexs = new Dictionary<string, List<Index>>()
                {
                    { indexName, rsIndex }
                }
            };

            return Response(res);
        }

        public object UpdateChart()
        {
            var context = ServerContext.ParseObject<JObject>();
            var apartmentId = context["ApartmentId"].ToString();
            var indexName = context["IndexName"].ToString();
            //var i = JsonConvert.DeserializeObject<Index>(context["Index"].ToString());

            var index = FireDetectionDb.Indexs.Find<IndexCollection>(apartmentId).Indexs[indexName].Last<Index>();

            return Response(index);
        }
    }
}
