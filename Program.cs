namespace ProiectPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

     

            List<Student> students = new List<Student>();


            for(int i = 1; i<= 5; i++)
            {
                Date_univ universitate1 = new Date_univ("Univeristatea Oradea", "Calculatoare", 2);
                Student student = new Student("Stundet-" + i, "Adresa-" +i ,  2000 + i , universitate1);
                student.displayStudent();
                students.Add(student);

                
            }

            Console.WriteLine("Dupa modificare " );

         

            students[2].Date_univ.Specializare = "TI";
            students[1].Date_univ.Specializare = "RST";


            for(int i = 0; i< students.Count; i++)
            {
                students[i].displayStudent();
            }





 
      
        }
    }
}
