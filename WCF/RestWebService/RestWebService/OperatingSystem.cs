using System.Runtime.Serialization;

namespace RestWebService
{
    [DataContract(Namespace = "http://barname-nevis.com/os")]
    public class OperatingSystem
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

    }
}
