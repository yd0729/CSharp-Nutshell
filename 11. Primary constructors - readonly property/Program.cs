var student = new Student("2021000477", "Bloggs", "Joe");

internal record Student(string ID, string LastName, string GivenName)
{
    // ID in the field initializer refers to the primary constructor parameter:
    public readonly int EnrolmentYear = int.Parse(ID.Substring(0, 4));

    // ID in the property initializer refers to the primary constructor parameter:
    public string ID { get; } = ID;

    // We can't non-destructive mutate ID, so storing it in this field is safe.
}