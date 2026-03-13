namespace Topic_8_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Maxym F.
            
            Part2();
        }

        public static void Part1() 
        {
            //Part 1-Reading In Colours

            Random Numbers = new Random();
            Numbers.Next(1, 5);
            List<string> colors = new List<string>();
            Console.WriteLine("I'm going to ask you for five different colours. I will then randomly display one of these colours.");
            Console.WriteLine();
            for (int i = 0; i < 5; i++) 
            {

                Console.WriteLine("Give me a colour!");
                colors.Add(Console.ReadLine());

            }

            Console.WriteLine();
            
            Console.WriteLine(string.Join(", " , colors));
            Console.WriteLine();

            Console.WriteLine("Here's a randomly selected colour from your list you gave me:");
            Console.WriteLine(colors[Numbers.Next(colors.Count)]);

        }

        public static void Part2() 
        {
            //Part 2-Random Numbers

            int usersImput, amountNums, max, min, between, count, wrong;

            count = 0;

            Random gen = new Random();
           
            List<int> numbers = new List<int>();

           

            Console.WriteLine("Think of a list of numbers. How many numbers are there?");
            int.TryParse(Console.ReadLine(), out amountNums);

            Console.WriteLine("What is the highest number?");
            int.TryParse(Console.ReadLine(), out max);

            Console.WriteLine("What is the lowest number?");
            int.TryParse(Console.ReadLine(), out min);

            if (max < min)
            {
                wrong = min;

                min = max;

                max = wrong;

            }

            for (int i = 1; i <= amountNums; i++)
            {
                numbers.Add(gen.Next(min, max +1));
            }
                
            Console.WriteLine(string.Join(", " , numbers));

            Console.WriteLine("Give me a number between " + min + " and " + max + " that you can see above.");
            int.TryParse(Console.ReadLine(), out between);

            for (int i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] == between) 
                {
                    count += 1;
                }

            }

            Console.WriteLine(string.Join(", ", between));
            Console.WriteLine("There are " + count + " " + between + "'s in this sequence.");

            Console.WriteLine();

            Console.WriteLine("Lets make " + between + " equal zero.");
            for (int i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] == between) 
                {
                    numbers[i] = 0;
                }

            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("Lets make all of the numbers equal to zero now!");

            Console.WriteLine() ;

            for (int i = 0; i < numbers.Count; i++) 
            {
                numbers[i] = 0;
            }
            
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine();

            Console.WriteLine("Lets generate some new numbers!");

            Console.WriteLine();
            
            for (int i = 1; i <= amountNums; i++)
            {

                numbers.Remove(gen.Next(0,1));
            }


            for (int i = 1; i <= amountNums; i++)
            {
                
                numbers.Add(gen.Next(min, max + 1));
            }

            Console.WriteLine(string.Join(", ", numbers));






        }
    }
}
