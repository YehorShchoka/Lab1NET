namespace Lab1
{
    public class Calculation_ab
    {

        int a, b;

        public Calculation_ab(int a, int b)
        {

            this.a = a; this.b = b;
        }

        public int A { get { return a; } }

        public int B { get { return b; } }

        public long Sun()
        {
            if (a > b)
                throw new ArgumentOutOfRangeException("A should be less than B");

            long product = 1;  
            bool found = false;

            for (int i = a; i <= b; i++)
            {
                if (i % 11 == 0 && i % 5 == 2)
                {
                    product *= i;
                    found = true;
                }
            }

            return found ? product : 0;
        }

    }
}
