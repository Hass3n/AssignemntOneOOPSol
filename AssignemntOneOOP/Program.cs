namespace AssignemntOneOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter First point ");
            //double.TryParse(Console.ReadLine(), out double x1);

            //double.TryParse(Console.ReadLine(), out double y1);
            //Point p1 = new Point(x1, y1);

            //Console.WriteLine("Enter Second point ");
            //double.TryParse(Console.ReadLine(), out double x2);

            //double.TryParse(Console.ReadLine(), out double y2);
            //Point p2 = new Point(x2, y2);
            //Console.WriteLine($"the Distance is {p1.Calcdistance(p2)}");

            #endregion



            #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person[] p=new Person[3];
            Person p1=new Person();




            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("Enter Your Name : ");

                String Name = Console.ReadLine();

                Console.WriteLine("Enter Your age : ");

                int.TryParse( Console.ReadLine(),out int age);

                p1 = new Person(Name, age); ;

                p[i] = p1;

               
            }

            p1.DisplayOldest(p);

            

            #endregion



        }
    }
}
