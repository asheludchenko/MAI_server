using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MAI_MobileService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
}
