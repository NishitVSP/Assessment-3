
// Base class: Student
class Student
{
    // Properties to store student's name, ID, and marks
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }
    // Constructor to initialize the properties when an object is created
    public Student(string name, int id, double marks)
    {
        Name = name; // Assigning the name parameter to the Name property
        ID = id;     // Assigning the id parameter to the ID property
        Marks = marks; // Assigning the marks parameter to the Marks property
    }

    // Method to determine grade based on marks
    public string GetGrade()
    {
        if (Marks >= 90) return "A"; // Grade A for marks >= 90
        if (Marks >= 75) return "B"; // Grade B for marks >= 75
        if (Marks >= 50) return "C"; // Grade C for marks >= 50
        return "F";                  // Grade F for marks < 50
    }

    // Virtual method to display student details (can be overridden in derived classes)
    public virtual void display()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}, Marks: {Marks}, Grade: {GetGrade()}");
        // Displays student's name, ID, marks, and grade
    }
}

// Derived class: StudentIITGN inherits from Student class
class StudentIITGN : Student
{
    // Additional property specific to IITGN students: Hostel Name
    public string Hostel_Name_IITGN { get; set; }

    // Constructor for StudentIITGN that calls the base class constructor and initializes Hostel_Name_IITGN
    public StudentIITGN(string name, int id, double marks, string hostel)
        : base(name, id, marks) // Calls the base class constructor to initialize Name, ID, and Marks
    {
        Hostel_Name_IITGN = hostel; // Initializes Hostel_Name_IITGN property
    }

    // Overriding the display method to include Hostel Name in the output
    public override void display()
    {
        base.display(); // Calls the base class display method to show common details
        Console.WriteLine($"Hostel Name: {Hostel_Name_IITGN}");
        // Displays additional information specific to IITGN students (Hostel Name)
    }
}