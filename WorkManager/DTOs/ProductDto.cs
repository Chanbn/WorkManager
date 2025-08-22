using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public class ProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Specification { get; set; }
        public int UnitPrice { get; set; }
        public string TimeUnit { get; set; }
        public int TimePerUnit { get; set; }
        public ProductDto(int productID, string productName, string specification, int unitPrice,string timeUnit, int timePerUnit)
        {
            ProductID = productID;
            ProductName = productName;
            Specification = specification;
            UnitPrice = unitPrice;
            TimeUnit = timeUnit;
            TimePerUnit = timePerUnit;
        }
        public override string ToString()
        {
            return $"{ProductID}. {ProductName} ({Specification}) - {UnitPrice}원, {TimePerUnit}초/단위";
        }

        public int CalculateTotalTime(int quantity)
        {
            if(TimeUnit=="minute")
            {
                return quantity * TimePerUnit * 60; // 분 단위를 초로 변환
            }
            else if(TimeUnit=="hour")
            {
                return quantity * TimePerUnit * 3600; // 시간 단위를 초로 변환
            }
            return quantity * TimePerUnit;
        }
    }
}
