namespace OOP_Encapsulation
{
    public enum PayTypeEnum
    {
        Hourly,
        Salaried,
        Commission
    }
    internal class EmployeePayTypeEnum
    {
        private PayTypeEnum _payType;
        public PayTypeEnum PayType
        {
            get => _payType;

            set => _payType = value;
        }
    }
}
