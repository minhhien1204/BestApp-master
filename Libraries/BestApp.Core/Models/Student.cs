using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestApp.Core.Models
{
    public class Student :Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int CourseId { get; set; }
    }
}
