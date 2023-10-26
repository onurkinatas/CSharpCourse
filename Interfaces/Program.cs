﻿//InterfacesIntro();

//Demo();

using Interfaces;

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}
static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}


static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Onur",
        LastName = "Kınataş",
        Adress = "İstanbul"
    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "Adem",
        LastName = "Kınataş",
        Departmant = "Computer Sciences"
    };

    manager.Add(customer);
    manager.Add(student);
}


interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}