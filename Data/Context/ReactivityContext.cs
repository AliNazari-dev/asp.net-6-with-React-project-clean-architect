using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Data.Context
{
    public class ReactivityContext : DbContext
    {

        #region Constructor

        public ReactivityContext(DbContextOptions<ReactivityContext> options) : base(options)
        {
            
        }
        #endregion

        #region
        public DbSet<Activity> Activities { get; set; }
        #endregion
    }
}
