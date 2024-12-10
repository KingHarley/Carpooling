using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Event
    {
        long Id { get; set; }
        string Name { get; set; } = null!;
        DateTimeOffset StartTime { get; set; }
        DateTimeOffset EndTime { get; set; }

    }
}
