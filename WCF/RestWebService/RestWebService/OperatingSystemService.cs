using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace RestWebService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OperatingSystemService : IOperatingSystemService
    {

        private readonly List<OperatingSystem> _osList = new List<OperatingSystem>()
        {
            new OperatingSystem {Id = "1", Name = "Windows", Description = "Windows Description goes here"},
        };
      
        public OperatingSystem GetOsData(string id)
        {
            return _osList.First(e => e.Id.Equals(id));
        }

        public void AddNewOs(OperatingSystem operatingSystem)
        {
            _osList.Add(operatingSystem);
        }

        public List<OperatingSystem> GetAllOperatingSystems()
        {
            return _osList;
        }
    }
}
