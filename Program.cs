using System;

namespace topic5keep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brandon Fraser
            int personOne;
            int personTwo;
            int personThree;
            Console.WriteLine("Enter the age of person one.");
            personOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age of person two.");
            personTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age of person three.");
            personThree = Convert.ToInt32(Console.ReadLine());
            //Easy
            if (personOne > personTwo)
                //working
                Console.WriteLine("Person 1 is older than person 2");
            if (personThree < personOne)
                //working
                Console.WriteLine("Person 3 is younger than person 1");
            if (personTwo == personThree)
                //working
                Console.WriteLine("Person 2 and person 3 are the same age");
            //Medium
            if (personTwo < personOne && personTwo < personThree)
                //working
                Console.WriteLine("Person 2 is the youngest");
            if (personOne > personTwo && personOne > personThree)
                //working
                Console.WriteLine("Person 1 is the oldest");
            //Harder Medium
            if (personOne != personThree && (personTwo == personOne || personTwo == personThree))
                //working
                Console.WriteLine("Person 2 is the same age as one other person");
            if (personOne != personTwo && personOne != personThree)
                //working
                Console.WriteLine("No one is the same age as person 1");
            if (personOne == personTwo && personOne == personThree && personTwo == personThree)
                //working
                Console.WriteLine("Everyone is the same age");
            if (personOne != personTwo && personOne != personThree && personTwo != personThree)
                //working
                Console.WriteLine("Everyone is a different age");
            //"Challenge"
            if ((personOne == personTwo && personTwo != personThree && personOne != personThree) || (personOne == personThree && personTwo != personThree && personOne != personTwo) || (personTwo == personThree && personOne != personThree && personOne != personTwo))
                //working
                Console.WriteLine("Exactly 2 people are the same age, but not everyone");
        }
    }
}
