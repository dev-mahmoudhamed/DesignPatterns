namespace DesignPatterns.BuilderPattern
{
    public class StudentBuilder : IBuilder
    {
        private readonly Student student;
        public StudentBuilder()
        {
            student = new Student();
        }
        public IBuilder setFirstName(string _firstName)
        {
            student.FirstName = _firstName;
            return this;
        }
        public IBuilder setLastName(string _lastName)
        {
            student.LastName = _lastName;
            return this;
        }
        public IBuilder setAge(int _age)
        {
            student.Age = _age;
            return this;
        }
        public IBuilder setGPA(double _gpa)
        {
            student.GPA = _gpa;
            return this;
        }
        public IBuilder setEmail(string _email)
        {
            student.Email = _email;
            return this;
        }
        public IBuilder setPhoneNumber(string _pnoneNumber)
        {
            student.PhoneNumber = _pnoneNumber;
            return this;
        }

        public Student build()
        {
            return student;
        }
    }
}