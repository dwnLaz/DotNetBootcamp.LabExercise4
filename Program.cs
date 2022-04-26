using System;

namespace CSharp.LabExercise4
{
    internal class Program
    {
        // Lab Exercise 4 - Shape
        interface IShape
        {
            string Name { get; set; }
            void ComputeArea();
            void DisplayArea();
        }

        abstract class ShapeDetails
        {
            public string Name { get; set; }
            public decimal Area { get; set; }
            public decimal FirstNumber { get; set; }
            public decimal SecondNumber { get; set; }
            public void DisplayArea()
            {
                Console.WriteLine($"{Name} Area: {Area}");
            }
        }

        class Circle : ShapeDetails, IShape
        {
            public Circle(decimal radius)
            {
                this.Name = "Circle";
                this.FirstNumber = radius;
            }
            public void ComputeArea()
            {
                this.Area = Math.Round(Convert.ToDecimal(Math.PI) * (this.FirstNumber * this.FirstNumber), 2);
            }
        }

        class Rectangle : ShapeDetails, IShape
        {
            public Rectangle(decimal length, decimal width)
            {
                this.Name = "Rectangle";
                this.FirstNumber = length;
                this.SecondNumber = width;
            }
            public void ComputeArea()
            {
                this.Area = this.FirstNumber * this.SecondNumber;
            }
        }

        class Square : ShapeDetails, IShape
        {
            public Square(decimal side)
            {
                this.Name = "Square";
                this.FirstNumber = side;
            }
            public void ComputeArea()
            {
                this.Area = this.FirstNumber * this.FirstNumber;
            }
        }

        // Lab Exercise 4 - Calculator
        interface ICalculate
        {
            void ComputeCalculation();
            void DisplayCalculation();
        }
        abstract class CalculateDetails
        {
            public decimal Result { get; set; }
            public string ResultName { get; set; }
            public decimal FirstNumber { get; set; }
            public decimal SecondNumber { get; set; }
            public void DisplayCalculation()
            {
                Console.WriteLine($"The {ResultName} of {FirstNumber} and {SecondNumber} is equal to {Result}\n");
            }
        }
        class Addition : CalculateDetails, ICalculate
        {
            public Addition(decimal firstNumber, decimal secondNumber)
            {
                this.ResultName = "Sum";
                this.FirstNumber = firstNumber;
                this.SecondNumber= secondNumber;
            }
            public void ComputeCalculation()
            {
                this.Result = this.FirstNumber + this.SecondNumber;
            }
        }
        class Subtraction : CalculateDetails, ICalculate
        {
            public Subtraction(decimal firstNumber, decimal secondNumber)
            {
                this.ResultName = "Difference";
                this.FirstNumber = firstNumber;
                this.SecondNumber = secondNumber;
            }
            public void ComputeCalculation()
            {
                this.Result = this.FirstNumber - this.SecondNumber;
            }
        }
        class Multiplication : CalculateDetails, ICalculate
        {
            public Multiplication(decimal firstNumber, decimal secondNumber)
            {
                this.ResultName = "Product";
                this.FirstNumber = firstNumber;
                this.SecondNumber = secondNumber;
            }
            public void ComputeCalculation()
            {
                this.Result = this.FirstNumber * this.SecondNumber;
            }
        }

        class Division : CalculateDetails, ICalculate
        {
            public Division(decimal firstNumber, decimal secondNumber)
            {
                this.ResultName = "Quotient";
                this.FirstNumber = firstNumber;
                this.SecondNumber = secondNumber;
            }
            public void ComputeCalculation()
            {
                this.Result = this.FirstNumber / this.SecondNumber;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----- SHAPE AREA -----");
            Console.WriteLine("[1] - Circle");
            Console.WriteLine("[2] - Rectangle");
            Console.WriteLine("[3] - Square\n");
            Console.WriteLine("----- CALCULATOR -----");
            Console.WriteLine("[4] - Calculator\n");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("----- CIRCLE AREA -----");
                    Console.Write("Enter radius: ");
                    decimal radius = Convert.ToDecimal(Console.ReadLine());

                    IShape shapeCircle = new Circle(radius);
                    shapeCircle.ComputeArea();
                    shapeCircle.DisplayArea();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("----- RECTANGLE AREA -----");
                    Console.Write("Enter length: ");
                    decimal length = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter width: ");
                    decimal width = Convert.ToDecimal(Console.ReadLine());

                    IShape shapeRectangle = new Rectangle(length, width);
                    shapeRectangle.ComputeArea();
                    shapeRectangle.DisplayArea();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("----- SQUARE AREA -----");
                    Console.Write("Enter side: ");
                    decimal side = Convert.ToDecimal(Console.ReadLine());

                    IShape shapeSquare = new Square(side);
                    shapeSquare.ComputeArea();
                    shapeSquare.DisplayArea();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("----- BASIC CALCULATOR -----");
                    Console.Write("Enter first number: ");
                    decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();

                    ICalculate addition = new Addition(firstNumber, secondNumber);
                    addition.ComputeCalculation();
                    addition.DisplayCalculation();

                    ICalculate subtraction = new Subtraction(firstNumber, secondNumber);
                    subtraction.ComputeCalculation();
                    subtraction.DisplayCalculation();

                    ICalculate multiplication = new Multiplication(firstNumber, secondNumber);
                    multiplication.ComputeCalculation();
                    multiplication.DisplayCalculation();

                    ICalculate division = new Division(firstNumber, secondNumber);
                    division.ComputeCalculation();
                    division.DisplayCalculation();

                    break;

                default:
                    Console.WriteLine("\nInvalid choice!\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
    }
}
