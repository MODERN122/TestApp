namespace TestApp
{

    public class CashSessionList
    {
        public CashSession[] cashSessions { get; set; }
    }

    public class CashSession
    {
        public string id { get; set; }
        public int? sessionNumber { get; set; }
        public int? fiscalNumber { get; set; }
        public object cashRegNumber { get; set; }
        public object cashRegSerial { get; set; }
        public string operationDate { get; set; }
        public string openDate { get; set; }
        public string closeDate { get; set; }
        public object acceptDate { get; set; }
        public object managerId { get; set; }
        public object responsibleUserId { get; set; }
        public float? sessionStartCash { get; set; }
        public float? payOrders { get; set; }
        public float? sumWriteoffOrders { get; set; }
        public float? salesCash { get; set; }
        public float? salesCredit { get; set; }
        public float? salesCard { get; set; }
        public float? payIn { get; set; }
        public float? payOut { get; set; }
        public float? payIncome { get; set; }
        public float? cashRemain { get; set; }
        public float? cashDiff { get; set; }
        public string sessionStatus { get; set; }
        public string conceptionId { get; set; }
        public string pointOfSaleId { get; set; }
        public string departmentId { get; set; }
        public string processedCashName { get; set; }
    }

}