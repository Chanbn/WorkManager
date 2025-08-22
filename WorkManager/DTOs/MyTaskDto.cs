using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public class MyTaskDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime StartTime { get; set; }
        public int workerOrderID { get; set; } // 추가된 속성
        public string status { get; set; }

        public MyTaskDto(string productName, int quantity,  DateTime startTime, int workerOrderID, string status)
        {
            ProductName = productName;
            Quantity = quantity;
            StartTime = startTime;
            this.workerOrderID = workerOrderID;
            this.status = status;
        }
    } 
}
