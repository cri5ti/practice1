using System;
using System.Collections.Generic;

namespace Test.Repository
{
  public interface ITimesheetRepository
  {
    List<Timesheet> GetTimesheets(Guid userId);
  }
}
