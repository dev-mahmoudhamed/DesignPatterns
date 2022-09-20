namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        public IBuilder setFirstName(string firstName);
        public IBuilder setLastName(string lastName);
        public IBuilder setAge(int age);
        public IBuilder setGPA(double gpa);
        public IBuilder setEmail(string email);
        public IBuilder setPhoneNumber(string phoneNumber);
        public Student build();
    }
}