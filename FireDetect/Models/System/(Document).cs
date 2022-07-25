using System;

namespace Models
{
    public interface IDocument
    {
        string ObjectId { get; }
    }

    public class Document : DataContext
    {

    }
}

//namespace Models
//{
//    public interface IDocument
//    {
//        string Id { get; set; }
//    }
//    public interface IBindingDocument
//    {
//        string ObjectId { get; set; }
//    }
//    public class Document : IDocument
//    {
//        public string Id { get; set; }
//        public Document Clone()
//        {
//            return (Document)this.MemberwiseClone();
//        }
//    }
//    public class DocumentInfo
//    {
//        public string Id { get; set; }
//        public DateTime? CreationTime { get; set; }
//        public DateTime? LastModifyTime { get; set; }
//        public long SizeOnDisk { get; set; }
//    }
//}
