namespace Employees
{
    public enum PayTypeEnum
    {
        Hourly,
        Salaried,
        Commission
    }
    internal class EmployeePayTypeEnum
    {
        protected PayTypeEnum _payType;
        public PayTypeEnum PayType
        {
            get => _payType;

            set => _payType = value;
        }
    }
}
