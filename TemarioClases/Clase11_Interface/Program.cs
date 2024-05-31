namespace Clase12_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new C();
            A a = b;

            Console.WriteLine(a.Informar());
        }

        public class A
        {
            public virtual string Informar()
            {
                return "kep you waiting, huh";
            }
        }

        public class B:A
        {
            public override string Informar()
            {
                return "ocelots are";
            }
        }

        public class C:B
        {
            public override string Informar()
            {
                return "youre pretty good";
            }
        }

    }
}