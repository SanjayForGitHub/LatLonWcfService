using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LatLonServiceContract
{
    [ServiceContract]
    public interface IStudentRegistrationService
    {
        [OperationContract]
        Task<string> Register(string firstName, string lastName);

        Task<string> RegisterWithDataContract(Student student);
    }

    [DataContract]
    public class Student {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
