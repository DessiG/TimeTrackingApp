using System;
using System.Collections.Generic;
using System.Data.Entity;
using TimeTrackingApp.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingApp.Model
{
    public class TimeTrackingDb : DbContext
    {
        public TimeTrackingDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
