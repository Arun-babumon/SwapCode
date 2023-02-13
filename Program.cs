namespace NewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entert the first number");
           var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Entert the Second  number");
            var v = int.Parse(Console.ReadLine());
            var tem = 0;
            tem = c;
            c = v;
            v = tem;
            Console.WriteLine("c = "+c+" v = "+v);
        }
    }
}