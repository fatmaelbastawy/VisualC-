using lab1_Icomparable;


internal class Program
{

    private static void Main(string[] args)
    {
        //    Point point1 = new Point(2, 2);
        //    Point point2 = new Point(2, 2);
        //    Point point3 = new Point(2, 2);
        //    Point point4 = new Point(2, 2);


        //    Point[] points = new Point[] { point1, point2, point3, point4 };
        //    Console.WriteLine(points);
        //    Array.Sort(points);
        //    points[3] = (Point)points[2].Clone();

        //    var point = point1.Clone();
        //    Console.WriteLine((point, point1));










        //Employee emp = new Employee(700, "fatma");
        //emp.ShowPayment();

        //Trainee tre = new Trainee(600, "nesma");
        //tre.ShowPayment();



        //Console.WriteLine();


        //Trainee tra1 = new Trainee(500, "fatma");
        //Trainee tra2 = new Trainee(700, "ahmed");
        //Trainee tra3 = new Trainee(345, "noha");
        //Trainee tra4 = new Trainee(9000, "Salwa");

        //Trainee[] trainee = new[] { tra1, tra2, tra3, tra4 };

        //Array.Sort(trainee, new usingComparer());


        //for (int i = 0; i < trainee.Length; i++)
        //{
        //    Console.WriteLine(trainee[i]);
        //}



        Point p1 = new Point();
        Point p2 = new Point();
        Point p3 = new Point();
        p1.x = 200;
        p2.x = 9;
        p3.x = 7;



        Point[] parray = new[] { p3, p2, p1 };

        Array.Sort(parray);

        for (int i = 0; i < parray.Length; i++)
        {
            Console.WriteLine(parray[i]);

        }
    }
}