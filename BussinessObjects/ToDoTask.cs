using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.BussinessObjects
{
    [DataContract]
    public class ToDoTask : EntityObject
    {
        [DataMember]
        public int Effort { get; set; }
    }
}
