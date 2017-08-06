using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        //Doesnt load property right away. Only gets it when you try to access it. 
        //First only retrieves the properties above.
        public virtual List<Post> Posts { get; set; } 
    }
}
