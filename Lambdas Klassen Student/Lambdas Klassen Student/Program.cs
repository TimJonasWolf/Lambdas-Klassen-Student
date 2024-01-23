
using Lambdas_Klassen_Student;


List<Student> liste = new List<Student>
{
	new Student {SNr=1,name="Awais"},

	new Student {SNr=2,name="Vladi"},

	new Student {SNr=3,name="Dejan"},

	new Student {SNr=4,name="Browly"},

	new Student {SNr=5,name="Zoro"},

	new Student {SNr=6,name="Rick"}

};

foreach(Student student in liste.OrderBy(x=> x.name))
{
	Console.WriteLine(student.SNr+ " " + student.name);
}
Console.WriteLine();

foreach (Student student in liste.OrderByDescending(x => x.SNr))
{
	Console.WriteLine(student.SNr + " " + student.name);
}

Console.WriteLine();

var listeNew = from x in liste
			  where x.name.Contains("B")
			  select x;

foreach (Student student in listeNew)
{ 
	Console.WriteLine(student.SNr + " " + student.name);
}

// FindAll,Select,OrderBy,OrderByDescending,from x in,where


