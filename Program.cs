namespace Ex5_2
{
    delegate int Calcu(int x, int y);
    class Program
    { 
        public static int sum(int x, int y)
        {
            return x + y;
        }

        public static int minus(int x, int y)
        {
            return x - y;
        }

        public static int multiply(int x, int y)
        {
            return x * y;
        }

        public static int divide(int x, int y)
        {
            return x / y;
        }

        public  static int result(int x, int y, Calcu c)
        {
            return c(x, y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("10 + 3 * 2 - 5");
            string process = "";
            int x = 3, y = 2;
            Calcu cal;
            Calcu cal2;
            Calcu cal3;
            Calcu cal4;
            cal = new Calcu (sum);
            cal2 = new Calcu(minus);
            cal3 = new Calcu(multiply);
            cal4 = new Calcu(divide);
            int r1 = result(x, y, cal3);
            process += "= 10 + " + r1.ToString() + " - 5";
            Console.WriteLine(process);
            process = "";
            x = r1; y = 10;
            int r2 = result(r1, y, cal);
            process += "= " + r2.ToString() + " - 5";
            Console.WriteLine(process);
            process = "";
            x = r2; y = 5;
            int r3 = result(x, y, cal2);
            process += "= " + r3.ToString();
            Console.WriteLine(process);
            Console.Read();
        }
    }
}