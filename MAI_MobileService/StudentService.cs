using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MAI_MobileService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class StudentService : IStudent
    {
        List<Student> studentList = null;
 
        public StudentService()
        {
            if(studentList == null)
            {
                studentList = new List<Student>();
            }
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public List<Student> GetStudentByName(string name)
        {
            return studentList.FindAll(a => a.Name.Equals(name));
        }

        public void DeleteStudentByID(int id)
        {
            studentList.Remove(studentList.Find(a => a.StudentID.Equals(Convert.ToString(id))));
        }
    }
}
