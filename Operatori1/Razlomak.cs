using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori1
{
    internal class Razlomak
    {
        int brojnik, nazivnik;
        public Razlomak(int brojnik, int nazivnik)
        {
            Brojnik = brojnik;
            Nazivnik = nazivnik;
        }
        public int Brojnik
        {
            get => brojnik;
            set
            {
                brojnik = value;
                Skrati();
            }
        }
        public int Nazivnik
        {
            get => nazivnik;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Nazivnik mora biti pozitivan!");
                }
                nazivnik = value;
                Skrati();
            }
        }
        public static Razlomak operator +(Razlomak A, Razlomak B)
            => new (A.Brojnik * B.Nazivnik + A.Nazivnik * B.Brojnik,
                A.Nazivnik * B.Nazivnik);
        public static Razlomak operator -(Razlomak A, Razlomak B)
            => new (A.Brojnik * B.Nazivnik - A.Nazivnik * B.Brojnik,
                A.Nazivnik * B.Nazivnik);
        public static Razlomak operator *(Razlomak A, Razlomak B)
            => new (A.Brojnik * B.Brojnik,
                A.Nazivnik * B.Nazivnik);
        public static Razlomak operator /(Razlomak A, Razlomak B)
        {
            if (B.Brojnik == 0)
                throw new Exception("Dijeljenje nulom!");
            return (B.Brojnik < 0) ?
                new(-A.Brojnik * B.Nazivnik, -A.Nazivnik * B.Brojnik) :
                new(A.Brojnik * B.Nazivnik, A.Nazivnik * B.Brojnik);
        }
        public static explicit operator Razlomak(int n)
            => new Razlomak(n, 1);
        //public static implicit operator double(Razlomak A)
        //    => A.Brojnik / (1.0 * A.Nazivnik);
        public override string ToString()
        {
            return Brojnik + "/" + Nazivnik;
        }
        //public static bool operator ==(Razlomak A, Razlomak B)
        //B.Equals(A)
        public bool Equals(Razlomak A)
        {
            return (Brojnik == A.Brojnik) && (Nazivnik == A.Nazivnik);
        }
        //B.Equals(obj)
        public override bool Equals(object? obj)
        {
            return obj is Razlomak && Equals(obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Brojnik, Nazivnik);
        }
        //nemamo && i || - idu iz & i |
        public static bool operator true(Razlomak A)
            => A.Brojnik == 1 && A.Nazivnik == 1;
        public static bool operator false(Razlomak A)
            => A.Brojnik == 0;
        public static Razlomak operator !(Razlomak A)
        {
            if (A.Brojnik == 0)
                return new(1, 1);
            else if (A.Brojnik == 1 && A.Nazivnik == 1)
                return new(0, 1);
            else
                return new(2, 1);
        }

        void Skrati()
        {
            for (int i = 2; i <= nazivnik; i++)
            {
                while(nazivnik % i == 0 && brojnik % i == 0)
                {
                    nazivnik /= i;
                    brojnik /= i;
                }
            }
        }
    }
}
