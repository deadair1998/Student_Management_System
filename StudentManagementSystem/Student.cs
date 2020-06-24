namespace StudentManagementSystem
{
  #region : Student :
  class Student
  {
    #region Class Variables...
    public double Grade;
    public int Id;
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
