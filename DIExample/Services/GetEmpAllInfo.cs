using DIExample.Data;
using System.Linq;

namespace DIExample.Services
{
    public class GetEmpAllInfo
    {
        private readonly ApplicationDbContext _db;
        public GetEmpAllInfo(ApplicationDbContext db)
        {
                _db = db;
        }
        public string GetEmployeeInformation()
        {
            var res = _db.Employees.Select(x => new { x.FullName, x.Salary, x.Email }).FirstOrDefault();
            return "Name: "+res.FullName+" Email: "+res.Email+" Salary:"+res.Salary;
        }
        
    }
}
