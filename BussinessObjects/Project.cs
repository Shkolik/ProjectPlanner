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
        public int ValuePrice
        {
            get; set;
        }

        [DataMember]
        public List<Item> Items
        {
            get; set;
        }

        protected override void SaveToDb()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Update(this);
                db.SaveChanges();
            }
        }
    }
}
