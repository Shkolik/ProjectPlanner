using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.BussinessObjects
{
    [DataContract]
    public class Project : EntityObject
    {
        [DataMember]
        public List<ToDoTask> Tasks
        {
            get; set;
        }

        [DataMember]
        public decimal ValuePrice
        {
            get; set;
        }

        [DataMember]
        public List<Item> Items
        {
            get; set;
        }
    }
}
