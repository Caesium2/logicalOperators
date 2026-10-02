Console.WriteLine("Enter an integer:");

int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (userNumber < 0)
{

    Console.WriteLine("The number is negative.");

}
else
{
    Console.WriteLine("The number is zero.");
}