var x = 150;
if (x is > 100) Console.WriteLine("x is greater than 100");

GetWeightCategory(15);
GetWeightCategory(20);
GetWeightCategory(25);

string GetWeightCategory(decimal bmi)
{
    return bmi switch
    {
        < 18.5m => "underweight",
        < 25m => "normal",
        < 30m => "overweight",
        _ => "obese"
    };
}