using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestWebService
{
    [ServiceContract]
    public interface IOperatingSystemService
    {
        [WebGet(UriTemplate = "os/{id}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        OperatingSystem GetOsData(string id);

        [WebInvoke(Method = "PUT", UriTemplate = "operatoringsystems")]
        [OperationContract]
        void AddNewOs(OperatingSystem operatingSystem);

        [WebGet(UriTemplate = "os",ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<OperatingSystem> GetAllOperatingSystems();
    }
}
