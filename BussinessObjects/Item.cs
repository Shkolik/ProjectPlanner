﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.BussinessObjects
{
    public class Item : EntityObject
    {
        public int Price { get; set; }

        public ItemType Type
        { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

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
