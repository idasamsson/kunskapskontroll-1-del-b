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
student1.Join(matematik);
student1.Join(historia);
engelska.Enroll(student1); // testar att lägga till en redan tillagd student.

student8.Leave(engelska); // studenten går inte kursen och bör få felmeddelande.

student2.Join(matematik);
matematik.Enroll(student4);
student7.Join(matematik); // kursen är full.

student3.Join(historia);
historia.Enroll(student6);
student3.Leave(historia);
historia.Enroll(student2);

engelska.Enroll(student5);
student2.Join(engelska);
student7.Join(engelska);

student1.Schedule();
engelska.RollCall();
matematik.RollCall();
historia.RollCall();
student7.Schedule();




