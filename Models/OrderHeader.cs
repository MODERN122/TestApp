using System.Collections;

namespace TestApp
{
    public class OrderHeaderList
    {
        public ICollection Orders { get; set; }
    }

    public class OrderHeader
    {
        public string id { get; set; }
        public int number { get; set; }
        public string serviceType { get; set; }
        public string deliveryExpectedTime { get; set; }
        public string openTime { get; set; }
        public string deliveryPrintTime { get; set; }
        public string dishServicePrintTime { get; set; }
        public string cookingFinishTime { get; set; }
        public string billTime { get; set; }
        public string sendTime { get; set; }
        public string actualTime { get; set; }
        public string closeTime { get; set; }
        public string deliveryCloseTime { get; set; }
        public float sum { get; set; }
        public float resultSum { get; set; }
        public float discountSum { get; set; }
        public string discount { get; set; }
        public int cashnumber { get; set; }
        public string cashname { get; set; }
        public object conception { get; set; }
        public int hashcode { get; set; }
        public string operationType { get; set; }
        public bool storned { get; set; }
        public string cashSessionId { get; set; }//cashSessionId
        public string typeName { get; set; }
        public object phone { get; set; }
        public object operatorId { get; set; }
        public object courierId { get; set; }
        public object departmentId { get; set; }
    }

}