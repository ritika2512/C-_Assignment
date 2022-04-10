using System.IO;
using System;
using System.Collections.Generic;
class Program
{
    public static List<double> AreaNCircum(int radius)
    {
        List<double> answer = new List<double>();
        double area = 3.14 * radius * radius;
        double circum = 2 * 3.14 * radius;
        answer.Add(area);
        answer.Add(circum);
        return answer;
    }
    static void Main()
    {
        Console.WriteLine("Enter radius of the circle");
        int radius = int.Parse(Console.ReadLine());
        List<double> areaAndCircum = new List<double>();
        areaAndCircum = AreaNCircum(radius);
        double area = areaAndCircum[0];
        double circum = areaAndCircum[1];
        Console.WriteLine("Area : {0} Circumference : {1}", area, circum);
    }
}