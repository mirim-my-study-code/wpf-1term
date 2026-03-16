using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ParkingManager
{
    // internal
    class CarInfo
    {
        public int No { get; set; }
        public string CarNumber{ get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public int ParkingFee { get; set; }
        public string DiscountCode { get; set; }
        public string Note { get; set; }
    }
}
