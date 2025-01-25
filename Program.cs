using System.Runtime.CompilerServices;

namespace day2;

public class Program
{
    public static void Main(String[] args)
    { 
        //create object of class car
            // Car myCar = new Car();
            // myCar.Make = "Toyota";
            // myCar.Model = "Corolla";
            // myCar.Year = 2010;
            // myCar.Color = "Red";
            // myCar.DisplayCarInfo();

        //class person
            // Person person1 = new Person();
            // person1.Name = "Maitri";
            // person1.Age = 21;
            // person1.DisplayDetails();
            // Person person2 = new Person();
            // person2.Name = "Monali";
            // person2.Age = 20;
            // person2.DisplayDetails();

        //class accessmodifiers
            // AccessModifiers person1 = new AccessModifiers();
            // person1.Name = "Maitri";
            // person1.SetAge(21);
            // Console.WriteLine(person1.GetAge());
            // person1.DisplayDetails();
            // AccessModifiers person2 = new AccessModifiers();
            // person2.Name = "Monali";
            // person2.SetAge(20);
            // Console.WriteLine(person2.GetAge());
            // person2.DisplayDetails();

        //class bankaccount
            // BankAccount account1 = new BankAccount();
            // account1.Deposit(2000);
            // account1.DisplayBalance();
            // account1.Withdraw(500);
            // account1.DisplayBalance();
            // account1.Withdraw(600);
            // account1.DisplayBalance();

        //class employee
            // Employee employee1 = new Employee();
            // employee1.Name = "Maitri";
            // employee1.SetSalary(20000);
            // employee1.DisplayEmployeeInfo();
            // Employee employee2 = new Employee();
            // employee2.Name = "Monali";
            // employee2.SetSalary(25000);
            // employee2.DisplayEmployeeInfo();

        //class defaultconstructors
            // DefaultConstructors car1 = new DefaultConstructors();
            // Console.WriteLine($"Car Make: {car1.CarMake}, Car Model: {car1.CarModel}");
            // Console.WriteLine($"Name: {car1.Name}, Age: {car1.Age}");
    
        //class parameterizedconstructor
            // ParameterizedConstructor car1 = new ParameterizedConstructor("Toyota", "Corolla", 2010, "Red");
            // car1.DisplayCarInfo();

            // ParameterizedConstructor myCar = new ParameterizedConstructor("Toyota", "Corolla", 2010, "Red");
            // myCar.DisplayCarInfo();

        //class parameterizedconstrtask
        //class book
            // Book book1 = new Book("It Ends With Us", "Colleen Hoover", 384);
            // book1.DisplayBookInfo();
            // Book book2 = new Book("The Silent Patient", "Alex Michaelides", 323);
            // book2.DisplayBookInfo();

        //class copyconstructor
            // CopyConstr car1 = new CopyConstr("Toyota", "Corolla", "Maitri", 21);
            // CopyConstr car2 = new CopyConstr(car1);
            // car2.DisplayCarInfo();

        //Copy Constructor Task
            // Student student1 = new Student("Maitri", 21, "A");
            // Student student2 = new Student(student1);
            // student2.DisplayStudentInfo();


        //class static constructor
            // StaticConstr car1 = new StaticConstr();
            // car1.DisplayCarInfo();
            // StaticConstr car2 = new StaticConstr();
            // car2.DisplayCarInfo();

        //class static cons task
        // Library library1 = new Library();
        // Library library2 = new Library();   
        // Library library3 = new Library();
        // Library library4 = new Library();
        // Library library5 = new Library();
        // Library.DisplayTotalBooks();
        

        //class private constructor
            // PrivateConstr obj1 = PrivateConstr.GetInstance();
            // PrivateConstr obj2 = PrivateConstr.GetInstance();
            // Console.WriteLine(ReferenceEquals(obj1, obj2));

        //class private constr task
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();
            Console.WriteLine(ReferenceEquals(logger1, logger2));
            logger1.LogMessage("This is a log message");
            logger2.LogMessage("This is another log message");
            
    }

}