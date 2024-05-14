using System.Security.Principal;

namespace Zachary_Renyhart_Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please select one of the choices below");
            Console.WriteLine();
            Console.WriteLine("Please press S for the area of a Square");
            Console.WriteLine("Please press C for the area of a Circle");
            Console.WriteLine("Please press R for the area of a Rectangle");
            Console.WriteLine();
            Console.WriteLine("Please press X to leave the applicaiton");
            string Output = Console.ReadLine();
            do 
            switch (Output)
            {
                case "S":
                case "s":
                    Console.WriteLine("Please input on side of your square");
                    Square square = new Square();
                    square.LengthOfSide = Convert.ToDouble(Console.ReadLine());
                    square.CalculateArea(square.LengthOfSide);


                    break;
                case "C":
                case "c":
                    Console.WriteLine("Please input the radius of your circle");
                    Circle circle = new Circle();
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                    circle.CalculateArea(circle.Radius);
                    break;


                case "R":
                case "r":
                    Console.WriteLine("Please input the width of your rectangle");
                    Rectangle rectangle = new Rectangle();
                    rectangle.Width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please input the height of your rectangle");
                    rectangle.Height = Convert.ToDouble(Console.ReadLine());
                    rectangle.CalculateArea(rectangle.Width, rectangle.Height);
                    break;


                case "X": //This prompts if the user presses "X" they will leave the application
                case "x":
                        break;
                    
                




            }
            while (Output != "X" &&  Output != "x");
            Console.WriteLine("You have left the application");



        }
    }

    public enum ColorValues { Red, Blue, Green, } //This is an enumeration that would only take on one of the 3 choices
    public class Shape
    {
        public string ShapeId { get; set; }
        public string ShapeName { get; set; }

        public int ShapeDescription { get; set; }
        public ColorValues Color { get; set; } //This will only accept Red,Blue,Green

        public virtual void CalculateArea()//This is a method. You must add virtual before the area
        {
            Console.WriteLine("This shape has an area.");
        }

    }

    public class Square : Shape //This now inherits everything from the class "Shape"
    {
        public double LengthOfSide { get; set; } //This is what needs to be instantiated to fill the value

        public void CalculateArea(double lengthOfSide) //This is a method to find the area
        {
            Console.WriteLine("The area of a square is: " + Math.Pow(lengthOfSide, 2));
        }
    }


    public class Circle : Shape
    {
        public double Radius { get; set; } //This is what needs to be instantied to fill the value
        public void CalculateArea(double radius) //This is the method to find the area 
        {
         Console.WriteLine("The area of a circle is: " + Math.PI * Math.Pow(radius, 2)); //This calculates the area of the circle
        }

       
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; } //This is what has to be instantiated to fill the value
        public double Height { get; set; } //This is what has to be instantiated to fill the value
        public void CalculateArea(double width, double height) //This is the method to find the area 
        {
            Console.WriteLine("The area of a rectangle is: " + width * height);
        }
    }
}
