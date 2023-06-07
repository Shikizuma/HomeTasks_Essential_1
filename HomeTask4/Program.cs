namespace HomeTask4
{
    internal class Program
    {
        /*
 
        Завдання 4 

        Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
        Потрібно: Створити класи Point та Figure. Клас Point повинен містити два цілих поля і одне рядкове поле. 
        Створити три властивості одним методом доступу get. Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів. 
        Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point. 
        Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; 
        void PerimeterCalculator(), що розраховує периметр багатокутника. Написати програму, яка виводить на екран назву та периметр багатокутника.
         
         */

        class Point
        {
            private int x;
            private int y;
            private string name;

            public int X
            {
                get { return x; }
            }

            public int Y
            {
                get { return y; }
            }

            public string Name
            {
                get { return name; }
            }

            public Point()
            {
                this.x = 0;
                this.y = 0;
                this.name = string.Empty;
            }

            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }
        }

        class Figure
        {
            private Point[] points;
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Figure(Point p1, Point p2, Point p3, Point p4 = null, Point p5 = null)
            {
                points = new Point[5];
                points[0] = p1;
                points[1] = p2;
                points[2] = p3;
                points[3] = p4;
                points[4] = p5;
            }

            public double LengthSide(Point A, Point B)
            {
                int dx = B.X - A.X;
                int dy = B.Y - A.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }

            public void PerimeterCalculator()
            {
                double perimeter = 0;

                for (int i = 0; i < points.Length - 1; i++)
                {
                    if (points[i] != null && points[i + 1] != null)
                    {
                        perimeter += LengthSide(points[i], points[i + 1]);
                    }
                }

                if (points[points.Length - 1] != null && points[0] != null)
                {
                    perimeter += LengthSide(points[points.Length - 1], points[0]);
                }

                Console.WriteLine("Perimetr: " + perimeter);
            }
        }


        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0, "A");
            Point p2 = new Point(0, 3, "B");
            Point p3 = new Point(4, 0, "C");

            Figure triangle = new Figure(p1, p2, p3);
            triangle.Name = "Test";
            Console.WriteLine("Name: " + triangle.Name);
            triangle.PerimeterCalculator(); 
        }
    }
}