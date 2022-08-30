using DIExample.Data;
using System.Linq;

namespace DIExample.Services
{
    public class GetEmpNameInfo : IGetEmpInfo
    {
        private readonly ApplicationDbContext _db;
        public GetEmpNameInfo(ApplicationDbContext db)
        {
            _db = db;
        }
        public string GetEmployeeInformation()
        {
         var res=_db.Employees.Select(x=>x.FullName).FirstOrDefault();
            return res;
        }
    }
}
