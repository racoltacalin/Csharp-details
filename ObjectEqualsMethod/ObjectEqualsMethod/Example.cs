using System;

namespace ObjectEqualsMethod
{
    class Example
    {
        public static void Main()
        {
            Rectangle r1 = new Rectangle(0, 0, 100, 200);
            Rectangle r2 = new Rectangle(0, 0, 100, 200);
            Rectangle r3 = new Rectangle(0, 0, 150, 200);

            Console.WriteLine("{0} = {1} : {2}", r1, r2, r1.Equals(r2));
            Console.WriteLine("{0} = {1} : {2}", r1, r3, r1.Equals(r3));
            Console.WriteLine("{0} = {1} : {2}", r2, r3, r2.Equals(r3));
        }
    }





    //class Example
    //{
    //    // Equals(Object)         -> Determines whether the specified object is equal to the current object.
    //    // Equals(Object, Object) -> Determines whether the specified object instances are considered equal.
    //    static void Main()
    //    {
    //        Point point2D = new Point(4, 4);
    //        Point3D point3Da = new Point3D(4, 4, 2);
    //        Point3D point3Db = new Point3D(4, 4, 2);
    //        Point3D point3Dc = new Point3D(4, 4, -1);


    //        Console.WriteLine("{0} = {1}: {2}",
    //            point2D, point3Da, point2D.Equals(point3Da));
    //        Console.WriteLine("{0} = {1}: {2}",
    //            point2D, point3Db, point2D.Equals(point3Db));
    //        Console.WriteLine("{0} = {1}: {2}",
    //            point3Da, point3Db, point3Da.Equals(point3Db));
    //        Console.WriteLine("{0} = {1}: {2}",
    //            point3Da, point3Dc, point3Da.Equals(point3Dc));
    //    }
    //}
}
