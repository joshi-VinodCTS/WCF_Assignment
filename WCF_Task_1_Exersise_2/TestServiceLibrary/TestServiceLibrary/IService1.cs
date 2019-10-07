using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace TestServiceLibrary
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<Openings> OpeningJobs();

        [OperationContract]
        IList<Openings> OpeningJobsByRole(string role);
    }

    [DataContract]
    public class Openings
    {
        [DataMember]
        public string JobTitle { get; set; }

        [DataMember]
        public string JobRole { get; set; }
    }
}
