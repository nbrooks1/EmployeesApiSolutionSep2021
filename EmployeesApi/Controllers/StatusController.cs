using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class StatusController : ControllerBase
    {
        [HttpGet("status")]
        public ActionResult GetTheStatus()
        {
            var response = new GetStatusResponse
            {
                Message = "Running Great!",
                WhenChecked = DateTime.Now
            };
            return Ok(response);
        }

    }


    public class GetStatusResponse
    {
        public string Message { get; set; }
        public DateTime WhenChecked { get; set; }
    }


}
