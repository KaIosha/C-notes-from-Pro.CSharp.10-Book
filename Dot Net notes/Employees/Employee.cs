namespace Employees
{
    class Employee : EmployeePayTypeEnum
    {
        //field data
        protected string _empName;
        protected int _empId;
        protected float _currPay;

        protected string empSSN; // to Apply Read Only property

        #region Aggregation 
        protected BenefitPackage EmpBenefits = new BenefitPackage();
        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        => EmpBenefits.ComputePayDeduction();
        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        } 
        #endregion
        public Employee()
        {
        }
        public Employee(string name, int empId, float pay)
        {
            _empName = name;
            _empId = empId;
            _currPay = pay;
        }
        public Employee(string name, int age, int id, float pay, string empSsn, PayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }

        public int Age { get; set; }

        /* we can use properties as variable in constructor to also make the validaation
          and not repeat the logic from the properites
        
        Also You can make this in the method use the prop Name instead of using the 
        private field
        
        */

        //public Employee(string name, int empId, float pay)
        //{
        //  Here!!!  (Name) = name;
        //  Here!!!  (Id) = empId;
        //  Here!!!  (Pay) = pay;
        //}

        #region Getter and Setter 
        //// Accessor (get method).
        //public string GetName() => _empName;

        //// Mutator (set method).
        //public void SetName(string name)
        //{
        //    // Do a check on incoming value
        //    // before making assignment.
        //    if (name.Length > 15)
        //    {
        //        Console.WriteLine("Error! Name length exceeds 15 characters!");
        //    }
        //    else
        //    {
        //        _empName = name;
        //    }
        //}
        #endregion


        /* value word:  is used to represent the incoming 
       value used to assign the property by the caller*/

        #region Properites 
        public string Name
        {
            get => _empName;

            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get => _empId;
            set => _empId = value;
        }
        public float Pay
        {
            get => _currPay;
            set => _currPay = value;
        }
        #endregion

        public string EmpSSN { get { return empSSN; } } //Read Only property
        //public int Id { set { _empId = value; }} // Write only Property


        //Mixing Private and Public Get/Set Methods on Properties
        public string SocialSecurityNumber
        {
            get => empSSN;
            private set => empSSN = value;
        }

        // This method can now be "overridden" by a derived class.
        public virtual void GiveBouns(float amount) => _currPay += amount;

        public virtual void DisplayStats()
        {

            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
    }
}
