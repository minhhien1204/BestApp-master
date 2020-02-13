using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestApp.Core.Models
{
    public class Cat : Entity
    {
        public string Name { get; set; } //ten co ID thi mac dinh la primary key
        public int Age { get; set; }

        //them vao
        public string keu { get; set; }
    }
}
