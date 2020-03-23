using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Repository
{
  public class TimesheetRepository : ITimesheetRepository
  {
    public List<Timesheet> GetTimesheets(Guid userId)
    {
      throw new NotImplementedException();

      return new List<Timesheet>(new[]
      {
        new Timesheet { Date = new DateTime(2020, 3, 23), Hours = 8.0m },
        new Timesheet { Date = new DateTime(2020, 3, 24), Hours = 6.0m },
        new Timesheet { Date = new DateTime(2020, 3, 25), Hours = 7.5m },
        new Timesheet { Date = new DateTime(2020, 3, 26), Hours = 8.0m },
        new Timesheet { Date = new DateTime(2020, 3, 16), Hours = 6.5m },
      });
    }
  }
}
