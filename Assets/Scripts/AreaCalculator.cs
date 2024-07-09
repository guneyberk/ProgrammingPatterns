using UnityEngine;


//This works well enough but you want to add more shapes you need to create new method for every shape

//namespace Open_Closed_Principle
//{
//    public class AreaCalculator
//    {
//        public float GetRectangleArea(Rectangle rectangle)
//        {
//            return rectangle.width * rectangle.height;
//        }

//        public float GetCircleArea(Circle circle)
//        {
//            return circle.radius * circle.radius * Mathf.PI;
//        }
//    }

//    public class Rectangle
//    {
//        public float width;
//        public float height;
//    }

//    public class Circle
//    {
//        public float radius;
//    }

//}

//Instead do this

namespace Open_Closed_Princible
{
    public abstract class Shape
    {
        public abstract float CalculateArea();
    }

    public class Rectangle : Shape
    {
        public float width;
        public float height;
        public override float CalculateArea()
        {
            return width * height;
        }
    }

    public class Circle : Shape
    {
        public float radius;
        public override float CalculateArea()
        {
            return radius * radius * Mathf.PI;
        }
    }

}