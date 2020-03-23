using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Repository;

namespace Test.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TimesheetController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<TimesheetController> _logger;
    private readonly ITimesheetRepository _timesheetRepository;

    public TimesheetController(ILogger<TimesheetController> logger, ITimesheetRepository timesheetRepository)
    {
      _logger = logger;
      _timesheetRepository = timesheetRepository;
    }

    [HttpGet]
    public IEnumerable<Timesheet> Get(string id)
    {
      return _timesheetRepository.GetTimesheets(Guid.Parse(id));
    }
  }
}
