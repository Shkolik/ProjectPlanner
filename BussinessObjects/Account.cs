using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.BussinessObjects
{
    public class Account : EntityObject
    {
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
