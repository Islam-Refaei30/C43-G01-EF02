using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Project
    {
        public int ProjectID { get; set; }
        public string? Name { get; set; }
        public DateOnly CreationDate { get; set; }

    }
}
