using Project_A;

Student student = new Student();
student.Id = 3456789;
student.Firstname = "Lihle";
student.Lastname = "Majoro";
student.ContactNumber = 76965878;
student.Address = "Gaborone, kopong";

Console.WriteLine(student.ToString());
Console.ReadLine();