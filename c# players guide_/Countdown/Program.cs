CountDown(10);
 void CountDown(int number)
{
    if (number == 0)
        return;
    Console.WriteLine(number);
    CountDown(number - 1);
}