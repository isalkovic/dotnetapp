using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_openshift.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(new
            {
                MachineName = Environment.MachineName,
                HostName = System.Net.Dns.GetHostName(),
                Computername = Environment.GetEnvironmentVariable("COMPUTERNAME"),
                HostName2 = Environment.GetEnvironmentVariable("HOSTNAME"),
            });
        }
    }
}