using DIExample.Data;
using DIExample.Models;
using DIExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace DIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IGetEmpInfo _info;
        private readonly GetEmpAllInfo _allInfo;
        private readonly Location _location;
        private readonly WelcomeMessageForMiddleWare _message;
        private readonly IGetNewGuid _getNewGuid1;
        private readonly IGetNewGuid _getNewGuid2;
        public EmployeeController(ApplicationDbContext db, IGetEmpInfo info,GetEmpAllInfo allInfo,IOptions<Location> location, WelcomeMessageForMiddleWare message,IGetNewGuid getNewGuid1, IGetNewGuid getNewGuid2)
        {
            _db = db;    
            _info = info;
            _allInfo = allInfo;
            _location = location.Value;
            _message = message;
            _getNewGuid1= getNewGuid1;
            _getNewGuid2 = getNewGuid2;
        }
        [HttpGet("getName")]
        public string getName()
        {
           // GetEmpNameInfo info = new GetEmpNameInfo(_db);
            var res =  _info.GetEmployeeInformation();
            res += " Location " + _location.Address;
            res += " GUID1 " + _getNewGuid1.GetGuid();
            res += " GUID2 " + _getNewGuid2.GetGuid();
            return (res);
        }
        [HttpGet("getEmail")]
        public string getEmail()
        {
            // GetEmpNameInfo info = new GetEmpNameInfo(_db);
            var res = _info.GetEmployeeInformation();
            res+=" Test: "+ _message.GetWelocme;
            res += " GUID1 " + _getNewGuid1.GetGuid();
            res += " GUID2 " + _getNewGuid2.GetGuid();
            return (res);
        }
        [HttpGet("AllInfo")]
        public  string AllInfo()
        {
            // GetEmpNameInfo info = new GetEmpNameInfo(_db);
            var res = _allInfo.GetEmployeeInformation();
            res += " GUID1 " + _getNewGuid1.GetGuid();
            res += " GUID2 " + _getNewGuid2.GetGuid();
            return (res);
        }

    }
}
