using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using chinookSystem.Data.Entities;
#endregion

namespace chinookSystem.DAL
{
    //This is an internal class for security reasons
    //Access is rastricted to within this class library porject
    //Inherits DbContext for EntityFramework, which requires
    //   System.Data.Entity
    internal class ChinookContext : DbContext
    {
        //Pass the connection string name to the
        //DbContext using :base()
        public ChinookContext() : base("ChinookDB")
        { }

        // Setup for all Dbset properties once the Entity classes are created
        public Dbset<Artist> Artists { get; set; }
        public Dbset<Album> Albums { get; set; }
        public Dbset<Track> Tracks { get; set; }
    }
}
