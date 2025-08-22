using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public class WorkHistoryDto
    {
        public int HistoryID { get; set; }
        public int WorkOrderID { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public DateTime TimeStamp { get; set; }

        public WorkHistoryDto(int historyID, int workOrderID, string userName, string status, DateTime timeStamp)
        {
            HistoryID = historyID;
            WorkOrderID = workOrderID;
            Username = userName;
            Status = status;
            TimeStamp = timeStamp;
        }
        public WorkHistoryDto(string userName, string status, DateTime timeStamp)
        {
            Username = userName;
            Status = status;
            TimeStamp = timeStamp;
        }
        public override string ToString()
        {
            return $"{Username}. - {Status} at {TimeStamp}";
        }
    }
}
