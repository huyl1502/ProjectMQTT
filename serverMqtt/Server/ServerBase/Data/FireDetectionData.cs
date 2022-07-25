using BsonData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Vst.Server.Data
{
    public class FireDetectionData : MasterDB
    {
        const string dbname = "FireDetections";
        public FireDetectionData(string path) : base(dbname, path) { }
        public FireDetectionData() : base(dbname) { }

        Collection _buildings;

        public Collection Buildings
        {
            get
            {
                if (_buildings == null)
                {
                    _buildings = this.GetCollection("Buildings");
                }
                return _buildings;
            }
        }

        Collection _apartments;

        public Collection Apartments
        {
            get
            {
                if (_apartments == null)
                {
                    _apartments = this.GetCollection("Apartments");
                }
                return _apartments;
            }
        }

        Collection _indexs;

        public Collection Indexs
        {
            get
            {
                if (_indexs == null)
                {
                    _indexs = this.GetCollection("Indexs");
                }
                return _indexs;
            }
        }
    }
}
