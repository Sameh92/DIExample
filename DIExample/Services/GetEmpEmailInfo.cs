using DIExample.Data;
using System.Linq;

namespace DIExample.Services
{
    public class GetEmpEmailInfo : IGetEmpInfo
    {
        private readonly ApplicationDbContext _db;
        public GetEmpEmailInfo(ApplicationDbContext db)
        {
                _db = db;
        }
        public string GetEmployeeInformation()
        {
            var res = _db.Employees.Select(x => x.Email).FirstOrDefault();
            return res;
        }
    }
}
