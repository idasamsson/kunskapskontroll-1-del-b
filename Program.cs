Course engelska = new("Engelska", 5);
Course matematik = new("Matematik", 10);
Course historia = new("Historia", 5);
Student student1 = new("Berit");
Student student2 = new("Stig");
Student student3 = new("Irene");
Student student4 = new("Ebbe");
Student student5 = new("Annie");
Student student6 = new("Sam");
Student student7 = new("Ing-Marie");
Student student8 = new("Leif");

Console.WriteLine(engelska);
Console.WriteLine(matematik);



 student1.Join(engelska);
 matematik.Enroll(student1);

 Console.WriteLine(student1);
