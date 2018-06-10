using LatLonServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LatLonWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentRegistrationService : IStudentRegistrationService
    {
        public Task<string> Register(string firstName, string lastName)
        {
            return Task.FromResult(string.Concat(firstName, " ", lastName));
        }

        public Task<string> RegisterWithDataContract(Student student)
        {
            return Task.FromResult(string.Concat(student.FirstName, " ", student.LastName));
        }
    }
}
