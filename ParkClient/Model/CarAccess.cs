using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkClient.Model
{
    public class CarAccess
    {
        public int Id { get; set; }

        public DateTime? In_time { get; set; }

        public DateTime? Out_time { get; set; }

        public int? Car_id { get; set; }

        public string Car_number { get; set; }

        public decimal? Charge { get; set; }
    }
}
