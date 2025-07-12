namespace delegates
{
    public delegate void ContrvariantsDel(Person person);
    public class Person { public Person() => Console.WriteLine("Constructor Person"); }
    public class Employee: Person 
    {
        public Employee() => Console.WriteLine("Constructor Employee");
    }
    public class User : Person
    {
        public User() => Console.WriteLine("Constructor User");
    }
    public class Program
    {
        public static void InfoPerson(Person person)=>Console.WriteLine(person.GetType().Name);
        //public delegate Person CovarianceDel();
        //public static Employee GetEmployee() => new Employee();
        //public static User GetUser() => new User();
        static void Main(string[] args)
        {
            ContrvariantsDel del;
            del = InfoPerson;
            del(new Employee());
            del(new User());
            //CovarianceDel del;
            //del = GetEmployee;
            //del();
            //del = GetUser;
            //del();
        }
    }
}
