using System.Collections;

namespace CustomEnumerator
{

    // we use IEnumerable and IEnumeerator to make the collection support the iteration
    //GetEnumerature exsits in IEnumrable interface


    //IEnumerable:  informs the caller that the object's items can be enumerated
    //IEnumerator:  allows the caller to obtain a container's items
    internal class Program
    {
        static void Main(string[] args)
        {



            Person[] person = new Person[3]
            {
                new Person ("Ahmed","Ali"),
                new Person ("Aya","Mona"),
                new Person ("mano","James")
            };

            People people = new People (person);

            foreach (Person item in people)
            {
                Console.WriteLine(item.fName+"\t"+item.lName);
            }

        }
    }

    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public Person()
        {
        }
        public Person(string fname, string lname)
        {
            this.fName = fname;
            this.lName = lname;
        }
    }


    public class People: System.Collections.IEnumerable
    {
        private Person[] persons;
        public People(Person[] person)
        {
            this.persons = person;
        }

        public IEnumerator GetEnumerator()
        {
            return persons.GetEnumerator();
        }
        
    }
}
