using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            return new[]
            {
                new Employee{Id = 1, Name = "山田 太郎", BirthDay = DateTime.Parse("1970/01/01")},
                new Employee{Id = 2, Name = "佐藤 花子", BirthDay = DateTime.Parse("2000/10/11")}
            };
          
        }
    }
}
