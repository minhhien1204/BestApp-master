using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestApp.Core.Models
{
    public class Course :Entity
    {
        public string Name { get; set; }
        public int Age { set; get; }
        public virtual List<Student> Students { get; set; }
    }
}
