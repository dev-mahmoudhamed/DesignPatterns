namespace DesignPatterns.BuilderPattern
{
    public class BuilderApp
    {
        public void Run()
        {
            IBuilder builder = Student.getBuilder();
            Student mahmoud = builder.setFirstName("Mahmoud").setLastName("Hamed").setAge(24).build();
            mahmoud.printInfo();
        }
    }
}