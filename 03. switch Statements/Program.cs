// switch Statements
{
    // switch statements may result in cleaner code than multiple if statements:

    ShowCard(5);
    ShowCard(11);
    ShowCard(13);

    static void ShowCard(int cardNumber)
    {
        switch (cardNumber)
        {
            case 13:
                Console.WriteLine("King");
                break;
            case 12:
                Console.WriteLine("Queen");
                break;
            case 11:
                Console.WriteLine("Jack");
                break;
            case -1:                // Joker is -1.
                goto case 12;       // In this game joker counts as queen.
            default:                // Executes for any other cardNumber.
                Console.WriteLine(cardNumber);
                break;
        }
    }
}

// switch Statement - Stacking Cases
{
    // When more than one value should execute the same code, you can list the common cases sequentially:

    int cardNumber = 12;

    switch (cardNumber)
    {
        case 13:
        case 12:
        case 11:
            Console.WriteLine("Face card");
            break;
        default:
            Console.WriteLine("Plain card");
            break;
    }
}

// switch Statements - patterns
{
    // From C# 7, you can switch on multiple types.

    TellMeTheType(12);
    TellMeTheType("hello");
    TellMeTheType(true);

    void TellMeTheType(object x)   // object allows any type.
    {
        switch (x)
        {
            case int i:
                Console.WriteLine("It's an int!");
                Console.WriteLine($"The square of {i} is {i * i}");
                break;
            case string s:
                Console.WriteLine("It's a string");
                Console.WriteLine($"The length of {s} is {s.Length}");
                break;
            default:
                Console.WriteLine("I don't know what x is");
                break;
        }
    }
}

// switch Statement - patterns - predicated
{
    object x = true;

    switch (x)
    {
        case bool b when b == true:     // Fires only when b is true
            Console.WriteLine("True!");
            break;
        case bool b:
            Console.WriteLine("False!");
            break;
    }
}

// switch Statements - patterns - stacked
{
    object x = 3000m;

    switch (x)
    {
        case float f when f > 1000:
        case double d when d > 1000:
        case decimal m when m > 1000:
            Console.WriteLine("We can refer to x here but not f or d or m");
            break;
    }
}

// switch expressions
{
    int cardNumber = 13;

    string cardName = cardNumber switch
    {
        13 => "King",
        12 => "Queen",
        11 => "Jack",
        _ => "Pip card"   // equivalent to 'default'
    };

    string suite = "spades";
    string cardName2 = (cardNumber, suite) switch   // tuple pattern
    {
        (13, "spades") => "King of spades",
        (13, "clubs") => "King of clubs",
        _ => "Other"
    };
}