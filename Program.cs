
class LAB10
{
    static void Main()
    {
        //int x = 2;
        //int y = x + x;
        //Console.WriteLine("Sum of x variable: " + y);
        //Class1.operations();
        //Class2.loop();

        // Create a Student object and display its details
        Student student = new Student("Nishit", 101, 85);
        student.display();// Output will include Name, ID, Marks, and Grade of Nishit
        Console.WriteLine(); // Blank line 

        // Create a StudentIITGN object and display its details including hostel name
        StudentIITGN iitgnStudent = new StudentIITGN("Jayesh", 102, 92, "Hostel J");

        iitgnStudent.display();// Output will include Name, ID, Marks, Grade, and "Hostel Name" of Jayesh
        Console.WriteLine(); // Blank line for better readability

    }
}
