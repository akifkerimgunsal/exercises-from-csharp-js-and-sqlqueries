namespace Inheritance_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Speak(); 
            teacher.Teach(); 

            Student student = new Student();
            student.Speak(); 
            student.Answer();
        }
    }
}
