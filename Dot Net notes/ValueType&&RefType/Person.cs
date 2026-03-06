namespace ValueType__RefType
{
    internal class Person
    {
        public string personName;
        public int personAge;

        public Person() { }
        public Person(string personName, int personAge)
        {
            this.personName = personName;
            this.personAge = personAge;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }

       
    }
}
