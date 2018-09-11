using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Model;

namespace TimeTrackingApp.ViewModel
{
    class EmployeeViewModel
    {
        TimeTrackingDb _db = new TimeTrackingDb();
        public EmployeeViewModel()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
               Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            Employee = _db.Employee.ToList();
        }

        public IList<Employee> Employee { get; set; }
    }
}
