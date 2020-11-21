using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Vector3
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector3(double X, double Y, double Z) => (x, y, z) = (X, Y, Z);

        public override string ToString() => $"({x}, {y}, {z})";

        public static Vector3 operator + (Vector3 m, Vector3 n)
            => new Vector3(m.x + n.x, m.y + n.y, m.z + n.z);

        public static Vector3 operator -(Vector3 m, Vector3 n)
        {
            return new Vector3(m.x - n.x, m.y - n.y, m.z - n.z);
        }

        public static Vector3 operator * (Vector3 m, Vector3 n)
        {
            return new Vector3(m.x * n.x, m.y * n.y, m.z * n.z);
        }

        public static Vector3 operator * (Vector3 m, int c)
        {
            return new Vector3(m.x * c, m.y * c, m.z * c);
        }

        public static Vector3 operator / (Vector3 m, int c)
        {
            return new Vector3(m.x / c, m.y / c, m.z / c);
        }

        public Vector3 Normalize()
        {
            double p = Math.Sqrt(x * x + y * y + z * z);
            return new Vector3(x / p, y / p, z / p);
        }

        public double GetLength()
        {
            double len = Math.Sqrt(x * x + y * y + z * z);
            return len;
        }
    }
}
