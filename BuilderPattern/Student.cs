namespace DesignPatterns.BuilderPattern
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public static IBuilder getBuilder()
        {
            return  new StudentBuilder();
        }

        public void printInfo()
        {
            Console.WriteLine($"Student first name is {FirstName}");
            Console.WriteLine($"Student last name is {LastName}");
            Console.WriteLine($"Student age is {Age}");
        }
    }
}