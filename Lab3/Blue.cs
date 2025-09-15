namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            List<double> ves = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                ves.Add(number);
            }
            foreach (double num in ves)
            {
                if (num < norma)
                {
                    milk += glass + glass;
                }
                else
                {
                    milk += glass;
                }
                    
            }
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            List<double> tchka = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                double x_i = Convert.ToDouble(Console.ReadLine());
                double y_i = Convert.ToDouble(Console.ReadLine());
                if (x_i > 0 && y_i > 0)
                    first += 1;
                else if (x_i < 0 && y_i > 0)
                    second += 1;
                else if (x_i < 0 && y_i < 0)
                    third += 1;
                else if (x_i > 0 && y_i < 0)
                    fourth += 1;

            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i <=n; i++)
            {
                    int ch1 = Convert.ToInt32(Console.ReadLine());
                    int ch2 = Convert.ToInt32(Console.ReadLine());
                    int ch3 = Convert.ToInt32(Console.ReadLine());
                    int ch4 = Convert.ToInt32(Console.ReadLine());
                    if (ch1 > 3 && ch2 > 3 && ch3 > 3 && ch4 > 3)
                        count += 1;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;

            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here

            // end

            return (power, agility, intellect);
        }
    }
}
