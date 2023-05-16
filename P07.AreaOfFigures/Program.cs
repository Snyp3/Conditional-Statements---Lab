using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle).
            //            На първия ред на входа се чете вида на фигурата(текст със следните възможности: square, rectangle, circle или triangle). 
            string figure = Console.ReadLine();
            double area= 0;

            //•	Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му
                if (figure == "square")
                 {    
                     double side = double.Parse(Console.ReadLine());
                     area = side * side;
                 }
            //•	Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му
                 else if (figure == "rectangle")
                 {
                     double a = double.Parse(Console.ReadLine());
                     double b = double.Parse(Console.ReadLine());
                     area = a * b;
                 }

            //•	Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга
                else if (figure == "circle")
                {
                    double r = double.Parse(Console.ReadLine());
                    area = r * r * Math.PI;
                }

             //•	Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа -дължината на страната му и дължината на височината към нея
                else if (figure == "triangle")
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = a * b / 2;
                }

            Console.WriteLine($"{area:F3}");    //Резултатът да се закръгли до 3 цифри след десетичната запетая. 

        }
    }
}
