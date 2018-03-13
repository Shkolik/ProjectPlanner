 using System;
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
    }
}
