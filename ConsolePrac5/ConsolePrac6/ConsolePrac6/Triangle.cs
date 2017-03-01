using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Triangle
    {
        double trLength;
        double trWidth;
        double area;
        double squareRtValue;


        public double AcceptValues()
        {
            WriteLine($"Enter the {trLength} of the triangle ");

            trLength = Convert.ToDouble(ReadLine());

            WriteLine($"Enter the {trWidth} of the triangle ");

            trWidth = Convert.ToDouble(ReadLine());


            //return  trLength * trWidth;

            return area = trLength * trWidth;
        }




        // unnecessary method below
        //i eliminated this step  through trial and error
        public double Squaring()
        {
            //double squareRtValue =   Math.Sqrt(area);
            return squareRtValue = Math.Sqrt(area);
        }


        public void ShowEverything()
        {
            AcceptValues();
            Squaring();
            //ShowArea();
            WriteLine($"The area of the Triangle is {area}");
            WriteLine($"The square root of the Triangle is {squareRtValue}");
            ReadKey();
        }

    }
}
