using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public class WorkOrderDto
    {
        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public int WorkerID { get; set; }
        public int Quantity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ExpectedEndtime { get; set; }
        public DateTime Actualendtime { get; set; }
        public WorkOrderDto(int workOrderID, int productID, int workerID, int quantity, DateTime startTime, DateTime expectedEndtime, DateTime actualendTime)
        {
            WorkOrderID = workOrderID;
            ProductID = productID;
            WorkerID = workerID;
            Quantity = quantity;
            StartTime = startTime;
            ExpectedEndtime = expectedEndtime;
            Actualendtime = actualendTime;  
        }
        public override string ToString()
        {
            return $"WorkOrder ID: {WorkOrderID}, Product ID: {ProductID}, Worker ID: {WorkerID}, Quantity: {Quantity}, Start Time: {StartTime}, Expected End Time: {ExpectedEndtime}, Actual End Time: {Actualendtime}";
        }

    }
}
