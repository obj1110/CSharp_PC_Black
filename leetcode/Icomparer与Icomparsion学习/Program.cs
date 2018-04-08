using System;
using System.Collections.Generic;
// Simple business object. A PartId is used to identify the type of part 
// but the part name can change. 
namespace SolutionWeb
{
    public class Part : IEquatable<Part>, IComparable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        //对于string类的一个重载
        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }

        //可以理解为显式的定义重载，我现在遇到的情况都是系统内置的方法，为了避免重名。
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        //Part是提前定义的一个自定义类
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        // Default comparer for Part type.
        public int CompareTo(Part comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.PartId.CompareTo(comparePart.PartId);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.

    }
    public class Example
    {
        public static void Main()
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 }); ;
            // Name intentionally left null.
            parts.Add(new Part() { PartId = 1334 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });


            // Write out the parts in the list. This will call the overridden 
            // ToString method in the Part class.
            Console.WriteLine("\nBefore sort:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }


            // Call Sort on the list. This will use the 
            // default comparer, which is the Compare method 
            // implemented on Part.
            parts.Sort();


            Console.WriteLine("\nAfter sort by part number:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // This shows calling the Sort(Comparison(T) overload using 
            // an anonymous method for the Comparison delegate. 
            // This method treats null as the lesser of two values.
            parts.Sort(delegate (Part x, Part y)
            {
                if (x.PartName == null && y.PartName == null) return 0;
                else if (x.PartName == null) return -1;
                else if (y.PartName == null) return 1;
                else return x.PartName.CompareTo(y.PartName);
            });

            Console.WriteLine("\nAfter sort by name:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            /*

                Before sort:
            ID: 1434   Name: regular seat
            ID: 1234   Name: crank arm
            ID: 1634   Name: shift lever
            ID: 1334   Name:
            ID: 1444   Name: banana seat
            ID: 1534   Name: cassette

            After sort by part number:
            ID: 1234   Name: crank arm
            ID: 1334   Name:
            ID: 1434   Name: regular seat
            ID: 1444   Name: banana seat
            ID: 1534   Name: cassette
            ID: 1634   Name: shift lever

            After sort by name:
            ID: 1334   Name:
            ID: 1444   Name: banana seat
            ID: 1534   Name: cassette
            ID: 1234   Name: crank arm
            ID: 1434   Name: regular seat
            ID: 1634   Name: shift level

             */
        }
    }
}


namespace Solution2
{
    class Su
    {
        public static void Main(string[] args)
        {
            Point[] pt = new Point[4];
            pt[0] = new Point(5, 1);
            pt[1] = new Point(2, 2);
            pt[2] = new Point(5, 2);
            pt[3] = new Point(7, 2);
            List<Point> lp = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                lp.Add(pt[i]);
            }
            lp.Sort(new CPointComparer());
        }
    }
    public class CPointComparer : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            if (p1.X > p2.X)
                return 1;
            else if (p1.X < p2.X)
                return -1;
            else if (p1.Y > p2.Y)
                return 1;
            else if (p1.Y < p2.Y)
                return -1;
            else return 0;
        }
    }
    public class Point
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public  Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

