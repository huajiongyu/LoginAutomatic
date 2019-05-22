using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAutomatic.Models
{
    public class StepModel
    {
        public int ID { get; set; }
        public List<PageStep> Steps { get; set; }
    }

    public class PageStep
    {
        public int Order { get; set; }

        public string URL { get; set; }

        public string ExeScript { get; set; }

        public string ValidScript { get; set; }
    }
}
