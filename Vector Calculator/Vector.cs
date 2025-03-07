﻿using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()


        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public float GetDirection()
        {
            return ((float)(MathF.Atan(x / y) * 180 / Math.PI));
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            // <2, 3, 4> + <6, 2, 6> = <8, 5, 10>
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(y, 2 * -1 , x );
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector Scale(Vector v)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector Normalize(Vector v)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector AngleBetween(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            return new Vector (Vector .DotProduct (v1, v2) (Math.Pow)(v2.GetMagnitude(), 2 ) * scalar));
        }
    }
}
