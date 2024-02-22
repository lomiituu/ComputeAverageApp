namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 grades separated by new line: ");

            double sum = 0;
            int i = 0;

            while (i < 5)
            {
                    
                double grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
                i++;

            }
            double average = sum / 5;
            double roundedAverage = Math.Round(average, 2);

            Console.WriteLine("The average grade is " + average + " and rounded off to " + Math.Round(average));

        }
    }
}