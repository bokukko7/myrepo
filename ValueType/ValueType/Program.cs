using System;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 100;
            Console.WriteLine(x);

            Value v;
            v = new Value();
            v.value = 1;

            Value u;
            u = new Value();

            Value w;
            w = v;
            w.value = 10;

            Console.WriteLine(v.value);
            Console.WriteLine(u.value);
            Console.WriteLine(w.value);
        }
    }

    class Value
    {
        public int value;
    }
}
