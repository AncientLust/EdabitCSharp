using System.Diagnostics.CodeAnalysis;

public struct Rational
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }
    public int Sign { get { return GetSign(this); } }

    public Rational(int num, int den)
    {
        if (den == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        // GCD also resolves situation when
        // both num and den are negative,
        // swapping both signs to positive.
        int gcd = GCD(num, den);
        Numerator = num / gcd;
        Denominator = den / gcd;
    }

    public override string ToString()
    {
        int sign = (Numerator < 0) ^ (Denominator < 0) ? -1 : 1;
        int absNumerator = Math.Abs(Numerator);
        int absDenominator = Math.Abs(Denominator);

        if (absDenominator == 1)
        {
            return (absNumerator * sign).ToString();
        }
        else
        {
            return (absNumerator * sign).ToString() + "/" + absDenominator.ToString();
        }
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    public static Rational operator +(Rational a, Rational b)
    {
        int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int den = a.Denominator * b.Denominator;
        return new Rational(num, den);
    }

    public static Rational operator -(Rational a, Rational b)
    {
        int num = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        int den = a.Denominator * b.Denominator;
        return new Rational(num, den);
    }

    public static Rational operator *(Rational a, Rational b)
    {
        int num = a.Numerator * b.Numerator;
        int den = a.Denominator * b.Denominator;
        return new Rational(num, den);
    }

    public static Rational operator /(Rational a, Rational b)
    {
        int num = a.Numerator * b.Denominator;
        int den = a.Denominator * b.Numerator;
        return new Rational(num, den);
    }

    public static Rational operator -(Rational r)
    {
        return new Rational(-r.Numerator, r.Denominator);
    }

    public static Rational operator +(Rational r)
    {
        return r;
    }

    //public static bool operator ==(Rational a, Rational b)
    //{
    //    return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
    //}

    //public static bool operator !=(Rational a, Rational b)
    //{
    //    return a.Numerator != b.Numerator || a.Denominator != b.Denominator;
    //}

    public static bool operator >(Rational a, Rational b)
    {
        return (decimal)a.Numerator / a.Denominator > (decimal)b.Numerator / b.Denominator;
    }

    public static bool operator <(Rational a, Rational b)
    {
        return (decimal)a.Numerator / a.Denominator < (decimal)b.Numerator / b.Denominator;
    }

    public static bool operator >=(Rational a, Rational b)
    {
        return (decimal)a.Numerator / a.Denominator >= (decimal)b.Numerator / b.Denominator;
    }

    public static bool operator <=(Rational a, Rational b)
    {
        return (decimal)a.Numerator / a.Denominator <= (decimal)b.Numerator / b.Denominator;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Rational other = (Rational)obj;
        return Numerator == other.Numerator && Denominator == other.Denominator;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 31 + Numerator.GetHashCode();
        hash = hash * 31 + Denominator.GetHashCode();
        return hash;
    }

    public static implicit operator Rational(decimal a)
    {
        // Determine an appropriate scale factor (e.g., 100 for two decimal places)
        int scaleFactor = (int)Math.Pow(10, GetDecimalPlacesCount(a));

        // Calculate the numerator
        int numerator = (int)(a * scaleFactor);

        // Create a Rational instance
        return new Rational(numerator, scaleFactor);
    }

    public static implicit operator decimal(Rational a)
    {
        return (decimal)a.Numerator / a.Denominator;
    }

    private static int GetSign(Rational r)
    {
        if (r.Numerator < 0 || r.Denominator < 0)
        {
            return -1;
        }
        else if (r.Numerator == 0 && r.Denominator == 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    static int GetDecimalPlacesCount(decimal value)
    {
        int count = 0;
        while (value != Math.Truncate(value))
        {
            value *= 10;
            count++;
        }

        return count;
    }
}
