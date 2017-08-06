using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab.BLL
{
    public class Adder
    {
        public DateTime addSeven(DateTime WedDate)
        {
            WedDate = WedDate.AddDays(7);
            return WedDate;
        }
    }
}
