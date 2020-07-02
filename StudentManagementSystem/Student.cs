namespace StudentManagementSystem
{
	#region : Student :
	class Student
	{
		#region Class Variables...
		public double Grade;
		public int Id;

		public Student()
		{
		}
		#endregion

		#region Constructor(s)...
		public Student(int id, double grade)
		{
			Id = id;
			Grade = grade;

		}
		#endregion
	}
	#endregion
}
