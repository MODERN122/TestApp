using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace TestApp
{
    public class Order
    {
        public string id { get; set; }
        public int number { get; set; }
        public string serviceType { get; set; }
        public object deliveryExpectedTime { get; set; }
        public string openTime { get; set; }
        public object deliveryPrintTime { get; set; }
        public string dishServicePrintTime { get; set; }
        public object cookingFinishTime { get; set; }
        public object billTime { get; set; }
        public object sendTime { get; set; }
        public object actualTime { get; set; }
        public string closeTime { get; set; }
        public object deliveryCloseTime { get; set; }
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
        public string cashSessionId { get; set; }
        public string typeName { get; set; }
        public object phone { get; set; }
        public object operatorId { get; set; }
        public object courierId { get; set; }
        public object departmentId { get; set; }
        public List<Payment> payments { get; set; }
        public List<Orderitemslist> orderItemsList { get; set; }
    }

    public class Payment
    {
        public string name { get; set; }
        public string paymentGroup { get; set; }
        public float paymentSum { get; set; }
        public float paymentSumRaw { get; set; }
    }

    public class Orderitemslist
    {
        public string nomenclatureId { get; set; }
        public Nomenclature nomenclature { get; set; }
        public string dishServicePrintTime { get; set; }
        public float amount { get; set; }
        public float fullSum { get; set; }
        public float resultSum { get; set; }
        public float discountSum { get; set; }
        public float fullPrice { get; set; }
        public float resultPrice { get; set; }
    }

    public class Nomenclature
    {
        public string id { get; set; }
        public string code { get; set; }
        public string num { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string accountingCategory { get; set; }
        public bool deleted { get; set; }
        public string type { get; set; }
        public float defaultSalePrice { get; set; }
        public string parent { get; set; }
    }

}