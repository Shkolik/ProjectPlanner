using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.BussinessObjects
{
    /// <summary>
    /// Abstraction for entity
    /// </summary>
    public interface IEntityObject
    {
        /// <summary>
        /// Object id
        /// </summary>
        int Id { get;set; }

        /// <summary>
        /// Object Name
        /// </summary>
        string Name { get; set; }

        void Save();
    }
}
