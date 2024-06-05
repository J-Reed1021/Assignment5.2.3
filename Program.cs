namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NaturalNumbers(10);

            void NaturalNumbers(int n)
            {
                if (n == 1)
                {
                    Console.Write(n);

                }
                else
                {
                    Console.Write(" " + n);
                    NaturalNumbers(n - 1);
                    
                }
            }
        }
    }
}