using System;

namespace Classes
{
    class Point
    {
        private int _x = 0; // this is an instance field which means every object you create has its own copy of x 
        private int _y = 0; //cannot use initialized variables : definite assignment rule 
        private static int objectCount = 0;
        public Point()
        {
            Console.WriteLine("Default constructor called");
        }
        public Point(int x, int y)
        {
            Console.WriteLine($"x:{x}, y:{y}");
            _x = x; // 'this' keyword is an alias for an instance 
            _y = y;
        }
        public double DistanceTo(Point other)
        {
            int xDiff = this._x - other._x; // the period(.) is the access modifier
            int yDiff = this._y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount() //what does static do? declares a class method. A class method is shared. objectcount() is  amethod  // int is the return type 
        {
            return objectCount;
        }
    }

}
