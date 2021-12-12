using System;

namespace Task1
{

    public class Ratio
    {
        public int numerator;
        public int denumerator;

        public Ratio(int Num, int Denum)
        {
            if (Num * Denum > 0)
            {
                numerator = Math.Abs(Num);
                denumerator = Math.Abs(Denum);
            }
            else
            {
                numerator = -Math.Abs(Num);
                denumerator = Math.Abs(Denum);
            }
        }

        public Ratio(int Num): this(Num, 1) { }
        public Ratio(): this(1, 1) { }

        public Ratio Simple_fraction()
        {
            int NOD;
            NOD = MyMath.Evklid(numerator, denumerator);
            numerator /= NOD;
            denumerator /= NOD;
            return new Ratio(numerator, denumerator);
        }
        public override string ToString()
        {
            if (numerator % denumerator == 0) return $"{Math.Abs(numerator) / Math.Abs(denumerator)}";
            if ((numerator / denumerator) != 0)
            {
                return $"{numerator / denumerator} {Math.Abs(numerator) % Math.Abs(denumerator)}/{denumerator}";
            }
            return $"{this.Simple_fraction().numerator}/{this.Simple_fraction().denumerator}";
        }
        
        public static Ratio operator +(Ratio X, Ratio Y)
        {
            Ratio NewR;
            int N, D;
            N = X.numerator * Y.denumerator + Y.numerator * X.denumerator;
            D = X.denumerator * Y.denumerator;
            NewR = new Ratio(N, D);
            NewR = NewR.Simple_fraction();
            return NewR;
        }

        public static Ratio operator ++(Ratio X)
        {
            Ratio Y = new Ratio(1, 1);
            return X + Y;

        }

        public static Ratio operator -(Ratio X, Ratio Y)
        {
            Ratio NewR;
            int N, D, NOD;
            N = X.numerator * Y.denumerator - Y.numerator * X.denumerator;
            D = X.denumerator * Y.denumerator;
            NewR = new Ratio(N, D).Simple_fraction();
            return NewR;            
        }

        public static Ratio operator --(Ratio X)
        {
            Ratio Y = new Ratio(1, 1);
            return X - Y;

        }

        public static Ratio operator *(Ratio X, Ratio Y)
        {
            int N, D;
            Ratio NewR;
            N = X.numerator * Y.numerator;
            D = X.denumerator * Y.denumerator;
            NewR = new Ratio(N, D).Simple_fraction();
            return NewR;
        }

        public static Ratio operator /(Ratio X, Ratio Y)
        {
            int N, D;
            Ratio NewR;
            N = X.numerator * Y.denumerator;
            D = X.denumerator * Y.numerator;
            NewR = new Ratio(N, D).Simple_fraction();
            return NewR;
        }

        public static bool operator ==(Ratio X, Ratio Y)
        {
            return ((X.Simple_fraction().numerator == Y.Simple_fraction().numerator) && (X.Simple_fraction().denumerator == Y.Simple_fraction().denumerator));
        }

        public static bool operator !=(Ratio X, Ratio Y)
        {
            return ((X.Simple_fraction().numerator != Y.Simple_fraction().numerator) || (X.Simple_fraction().denumerator != Y.Simple_fraction().denumerator));
        }

        public static bool operator >(Ratio X, Ratio Y)
        {
            int N1, N2;
            N1 = X.numerator * Y.denumerator;
            N2 = Y.numerator * X.denumerator;
            return (N1 > N2);

        }

        public static bool operator <(Ratio X, Ratio Y)
        {
            int N1, N2;
            N1 = X.numerator * Y.denumerator;
            N2 = Y.numerator * X.denumerator;
            return (N1 < N2);

        }

        public static bool operator <=(Ratio X, Ratio Y)
        {
            return ((X == Y) || (X < Y));
        }
        public static bool operator >=(Ratio X, Ratio Y)
        {
            return ((X == Y) || (X > Y));
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ratio X = new Ratio(-1,-2);
            Ratio Y = new Ratio(-5, 2);
            Console.WriteLine($"{X}      {Y}");
            Ratio Z;
            Z = X + Y;
            Console.WriteLine(Z);
            Z = Z - Y;
            Z--;
            Console.WriteLine(Z);



        }
    }
}
