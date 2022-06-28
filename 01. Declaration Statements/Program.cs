{
    // You may declare multiple variables of the same type in a comma-separated list:

    string someWord = "rosebud";
    int someNumber = 42;
    bool rich = true, famous = false;
}

{
    const double c = 2.99792458E08;
    //c += 10;                        // Compile-time Error
}

{
    // The scope of a local or constant variable extends throughout the current block:

    int x;
    {
        int y;
        //int x;            // Error - x already defined
    }

    {
        int y;            // OK - y not in scope
    }

    //Console.Write(y);  // Error - y is out of scope
}