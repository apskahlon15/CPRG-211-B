using System;
namespace program
{
    class program
    {
        static void Main(string[] args)

        {
            int low_no;
            int high_no;



            Console.WriteLine("Enter a lower number : ");
            low_no = int.Parse(Console.ReadLine());


            while (low_no < 0)
            {
                Console.WriteLine("Enter a positive lower number ");
                Console.Write("Enter a lower number:");
                low_no = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter a high number : ");
            high_no = int.Parse(Console.ReadLine());



            while (high_no < low_no)
            {
                Console.WriteLine("Enter a high number greater than lower number :  ");
                Console.Write("Enter a higher number : ");
                high_no = int.Parse(Console.ReadLine());

            }
            int difference = high_no - low_no;
            Console.WriteLine($"The difference between lower and high number = {difference}");
            int[] num = new int[difference];


            for (int n = low_no, i = 0; n <= high_no && i < difference; n++, i++)
            {
                num[i] = n;
            }

            StreamWriter streamWriter = File.CreateText("data.txt");
            for (int i = num.Length - 1; i >= 0; i--)
            {
                streamWriter.WriteLine(num[i]);
            }
            streamWriter.Close();

            Console.WriteLine("Wrote to file: data.txt");

            foreach (int n in num)
            {
                if (IsPrime_no(n))
                {
                    Console.WriteLine($"{n} is a Prime Number.");
                }
            }

        }
    static bool IsPrime_no(int n)
        {
            for (int denominator = n - 1; denominator >1 ; denominator--)
            {
                int remiander = n%denominator;

                if(remiander == 0)
                    return false;

            }
            return true;
        }
    }
}





  