using Task_linq;

StudentService studentService = new StudentService();

Student stud1 = new Student
{
    DateOfBirth = DateTime.Now,
    FirstName = "Test",
    Id = 1,
    LastName = "Test1",
};

Student student1 = new Student { LastName = "Test2",Id=2,FirstName="sss",DateOfBirth=DateTime.Now};

studentService.AddStudent(1,"Behzod","Qulmatov", DateTime.Now);
studentService.AddStudent(2,"Behzod1","Qulmatov1", DateTime.Now);

var res=studentService.GetStudents();

foreach (var ss in res)
{
    Console.WriteLine(ss.ToString());
}
