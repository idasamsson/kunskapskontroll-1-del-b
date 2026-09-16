Course engelska = new("Engelska", 5);
Course matematik = new("Matematik", 3);
Course historia = new("Historia", 5);
Student student1 = new("Berit");
Student student2 = new("Stig");
Student student3 = new("Irene");
Student student4 = new("Ebbe");
Student student5 = new("Annie");
Student student6 = new("Sam");
Student student7 = new("Ing-Marie");
Student student8 = new("Leif");

 student1.Join(engelska);
 student6.Join(historia);
 student6.Join(engelska);
 student3.Join(matematik);
 matematik.Enroll(student1);
 matematik.Enroll(student6);
matematik.Remove(student6);

//Console.WriteLine(student1);
Console.WriteLine(student6);
//Console.WriteLine(engelska);
Console.WriteLine(matematik);
matematik.RollCall();
