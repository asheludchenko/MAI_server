using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MAI_MobileService
{
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        void AddStudent(Student student);
        [OperationContract]
        List<Student> GetStudentByName(string name);
        [OperationContract]
        void DeleteStudentByID(int id);
    }
}
