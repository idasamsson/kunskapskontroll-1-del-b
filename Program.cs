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
student1.Join(engelska);

student1.Schedule();
engelska.RollCall();

/*
student2.Join(matematik);
student3.Join(historia);
matematik.Enroll(student4);
engelska.Enroll(student5);
historia.Enroll(student6);
student7.Join(matematik);
student8.Join(matematik);
student3.Leave(historia);
engelska.Remove(student1);
student2.Join(engelska);
historia.Enroll(student2);
student5.Join(engelska);
*/
//student2.Schedule();
//matematik.RollCall();



