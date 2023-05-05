using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Icomparable
{
   



        public class Point : IComparable
        {
            public int x { get; set; }

            public int y { get; set; }




            public int CompareTo(object obj)
            {  
               
                Point temp = obj as Point;         
                if (this.x == temp.x)
                    return 0;
                else if (this.x > temp.x)
                    return 1;
                else
                    return -1;
                //return this.x.CompareTo(temp.x);
            }
            public override string ToString()
            {
                return x.ToString();
            }


            //public Point Clone()
            //{
            //    var point = (Point)MemberwiseClone();
            //    point.X = X; point.Y = Y;
            //    return point;
            //    throw new NotImplementedException();
            //}


            public void Print(Point[] arr)

            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }



            //object ICloneable.Clone()
            //{
            //    throw new NotImplementedException();
            //}
        }
    }



