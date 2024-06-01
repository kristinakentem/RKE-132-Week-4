using static System.Runtime.InteropServices.JavaScript.JSType;

Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool- true/false
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.Writeline($”cpu has generated{cpuRandom}.”);
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //LoopActive=false;
        break;
    }
    else
    {
        Console.WriteLine("Oops.Try again.");
    }
}
Console.WriteLine("Have a nice day!");

