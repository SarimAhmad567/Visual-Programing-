using System;

// Enum Definition
public enum Department
{
    ComputerScience,
    ElectricalEngineering,
    MechanicalEngineering
}

// Person Class
public class Person
{
    private string name;

    // No-argument constructor
    public Person()
    {
        this.name = null;
    }

    // Multi-argument constructor
    public Person(string name)
    {
        this.name = name;
    }

    // Public property for name
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
}

// Student Class
public class Student : Person
{
    private string regNo;
    private int age;
    private Department program;

    // No-argument constructor
    public Student() : base()
    {
        this.regNo = null;
        this.age = 0;
        this.program = Department.ComputerScience; // default department
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program)
        : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    // Public property for regNo
    public string RegNo
    {
        get { return this.regNo; }
        set { this.regNo = value; }
    }

    // Public property for age
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    // Public property for program
    public Department Program
    {
        get { return this.program; }
        set { this.program = value; }
    }
}

// Program Class for demonstration
public class Program
{
    public static void Main()
    {
        // Create a new Student object using no-argument constructor
        Student student1 = new Student();
        student1.Name = "John Doe";
        student1.RegNo = "S12345";
        student1.Age = 20;
        student1.Program = Department.ElectricalEngineering;

        // Create a new Student object using multi-argument constructor
        Student student2 = new Student("Jane Doe", "S67890", 22, Department.MechanicalEngineering);

        // Print student details
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine($"Name: {student1.Name}");
        Console.WriteLine($"Reg No: {student1.RegNo}");
        Console.WriteLine($"Age: {student1.Age}");
        Console.WriteLine($"Program: {student1.Program}");

        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine($"Name: {student2.Name}");
        Console.WriteLine($"Reg No: {student2.RegNo}");
        Console.WriteLine($"Age: {student2.Age}");
        Console.WriteLine($"Program: {student2.Program}");
    }
}