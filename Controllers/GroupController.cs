using Microsoft.AspNetCore.Mvc;
using System.DirectoryServices;

namespace docu_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "SuperUser"
        };

        private readonly ILogger<GroupController> _logger;

        public GroupController(ILogger<GroupController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGroup")]
        public List<string> Get()
        {
            return Summaries.ToList();
        }

        
    }
}