using System;

namespace UserInputJefferyThurgood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Jeffery Thurgood!");
            string UserFeedback;
            Console.WriteLine("What can I do to help?"); 
            UserFeedback=Console.ReadLine();
            Console.WriteLine("You typed:" + UserFeedback);
        }
    }
}
