namespace Deep_Dive_In_LINQ
{
    internal class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Index = 1,
                    EmployeeNo="3943424",
                    Name ="Ahmed Ali",
                    Email= "AhmedAli123@gamil.com",
                    Salary=100,
                    Skills = new (){"Java" ,"Python" }
                },
                  new Employee
                {
                    Index = 2,
                    EmployeeNo = "3943425",
                    Name = "Mohamed Hassan",
                    Email = "MohamedHassan@gmail.com",
                    Salary = 100,
                    Skills = new() { "C#", ".NET", "SQL" }
                },

                new Employee
                {
                    Index = 3,
                    EmployeeNo = "3943426",
                    Name = "Youssef Wael",
                    Email = "YoussefWael@gmail.com",
                    Salary = 100332423,
                    Skills = new() { "C++", "Problem Solving", "LINQ" }
                },

                new Employee
                {
                    Index = 4,
                    EmployeeNo = "3943427",
                    Name = "Sara Mostafa",
                    Email = "SaraMostafa@gmail.com",
                    Salary = 78000,
                    Skills = new() { "JavaScript", "React", "HTML", "CSS" }
                },

                new Employee
                {
                    Index = 5,
                    EmployeeNo = "3943428",
                    Name = "Omar Khaled",
                    Email = "OmarKhaled@gmail.com",
                    Salary = 110000,
                    Skills = new() { "Node.js", "MongoDB", "Express" }
                },

                new Employee
                {
                    Index = 6,
                    EmployeeNo = "3943429",
                    Name = "Mariam Adel",
                    Email = "MariamAdel@gmail.com",
                    Salary = 97000,
                    Skills = new() { "Python", "Django", "PostgreSQL" }
                },

                new Employee
                {
                    Index = 7,
                    EmployeeNo = "3943430",
                    Name = "Ali Mahmoud",
                    Email = "AliMahmoud@gmail.com",
                    Salary = 68000,
                    Skills = new() { "Flutter", "Dart", "Firebase" }
                },

                new Employee
                {
                    Index = 8,
                    EmployeeNo = "3943431",
                    Name = "Nour Tarek",
                    Email = "NourTarek@gmail.com",
                    Salary = 120000,
                    Skills = new() { "Azure", "Docker", "Kubernetes" }
                },

                new Employee
                {
                    Index = 9,
                    EmployeeNo = "3943432",
                    Name = "Hana Sameh",
                    Email = "HanaSameh@gmail.com",
                    Salary = 89000,
                    Skills = new() { "UI/UX", "Figma", "Adobe XD" }
                },

                new Employee
                {
                    Index = 10,
                    EmployeeNo = "3943433",
                    Name = "Karim Nasser",
                    Email = "KarimNasser@gmail.com",
                    Salary = 115000,
                    Skills = new() { "Machine Learning", "Python", "TensorFlow" }
                },
                new Employee
                {
                    Index = 11,
                    EmployeeNo = "3943434",
                    Name = "Khaled Fathy",
                    Email = "KhaledFathy@gmail.com",
                    Salary = 76000,
                    Skills = new() { "C", "Embedded Systems", "Arduino" }
                },

                new Employee
                {
                    Index = 12,
                    EmployeeNo = "3943435",
                    Name = "Salma Ahmed",
                    Email = "SalmaAhmed@gmail.com",
                    Salary = 99000,
                    Skills = new() { "Angular", "TypeScript", "RxJS" }
                },

                new Employee
                {
                    Index = 13,
                    EmployeeNo = "3943436",
                    Name = "Amr Yasser",
                    Email = "AmrYasser@gmail.com",
                    Salary = 83000,
                    Skills = new() { "PHP", "Laravel", "MySQL" }
                },

                new Employee
                {
                    Index = 14,
                    EmployeeNo = "3943437",
                    Name = "Nada Sherif",
                    Email = "NadaSherif@gmail.com",
                    Salary = 91000,
                    Skills = new() { "Data Analysis", "Power BI", "Excel" }
                },

                new Employee
                {
                    Index = 15,
                    EmployeeNo = "3943438",
                    Name = "Mostafa Samir",
                    Email = "MostafaSamir@gmail.com",
                    Salary = 105000,
                    Skills = new() { "ASP.NET Core", "Entity Framework", "SQL Server" }
                },

                new Employee
                {
                    Index = 16,
                    EmployeeNo = "3943439",
                    Name = "Reem Adel",
                    Email = "ReemAdel@gmail.com",
                    Salary = 73000,
                    Skills = new() { "UI Design", "Photoshop", "Illustrator" }
                },

                new Employee
                {
                    Index = 17,
                    EmployeeNo = "3943440",
                    Name = "Mahmoud Essam",
                    Email = "MahmoudEssam@gmail.com",
                    Salary = 118000,
                    Skills = new() { "DevOps", "CI/CD", "Jenkins" }
                },

                new Employee
                {
                    Index = 18,
                    EmployeeNo = "3943441",
                    Name = "Farah Nabil",
                    Email = "FarahNabil@gmail.com",
                    Salary = 87000,
                    Skills = new() { "Swift", "iOS", "Xcode" }
                },

                new Employee
                {
                    Index = 19,
                    EmployeeNo = "3943442",
                    Name = "Yahia Adel",
                    Email = "YahiaAdel@gmail.com",
                    Salary = 95000,
                    Skills = new() { "Cyber Security", "Networking", "Linux" }
                },

                new Employee
                {
                    Index = 20,
                    EmployeeNo = "3943443",
                    Name = "Malak Hossam",
                    Email = "MalakHossam@gmail.com",
                    Salary = 112000,
                    Skills = new() { "AI", "Deep Learning", "PyTorch" }
                }

                            };
        }
    }

    internal class Employee
    {
        public int Index { get; set; }
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public List<string> Skills { get; set; }= new();
    }
}
