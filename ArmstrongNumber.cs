namespace ArmstrongNumber;

public static class ArmstrongNumber
{
    public static bool Calculate(int number)
    {
        var rest = 0;
        for (var i = number; i > 0; i = i/10)
        {
            var remainder = i%10;
            rest = rest + (int)Math.Pow(remainder, 3);
        }

        return rest == number ? true : false;
    }
}
