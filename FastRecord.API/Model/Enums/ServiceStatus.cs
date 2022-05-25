using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastRecord.API.Model.Enums
{
    public enum ServiceStatus
    {
        Created = 0,
        InProgress = 1,
        InPause = 2,
        Cancelled = 3,
        Finished = 4
    }
}
