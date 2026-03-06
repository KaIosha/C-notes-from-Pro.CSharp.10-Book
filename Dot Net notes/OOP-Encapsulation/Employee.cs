namespace OOP_Encapsulation
{
    class Employee
    {
        //field data
        private string _empName;
        private int _empId;
        private float _currPay;

        private string empSSN; // to Apply Read Only property

        public Employee()
        {
        }
        public Employee(string name, int empId, float pay)
        {
            _empName = name;
            _empId = empId;
            _currPay = pay;
        }

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
        

        public void GiveBouns(float amount) => _currPay += amount;

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_empName}\nID: {_empId}\nPay: {_currPay}\n");
        }
    }
}
