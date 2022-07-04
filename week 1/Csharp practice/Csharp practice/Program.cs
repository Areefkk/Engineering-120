class HelloWorld
{
    static void Main(string[] args)
    {
        int counter = 0;
        do // This is a different version from the while loop, where the condition is tested at the end 
        {  // of the loop and not beginning. Can be useful if we need to run the body of the loop once to establish the paramentersd of the condioton before doing the test.
            if (counter % 2 == 0)
                System.Console.WriteLine("Counter: " + counter);
            else
                System.Console.WriteLine("The number is odd!");
            counter++;
        } while (counter < 10); // While condition is true run this loop
    }
}