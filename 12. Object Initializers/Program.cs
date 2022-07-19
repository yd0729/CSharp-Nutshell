// Fields or properties can be initialized in a single statement directly after construction:

// Object initialization syntax. Note that we can still specify constructor arguments:

Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };

// Instead of using object initializers, we could make Bunny’s constructor accept optional parameters.
// This has both pros and cons (see book):

Bunny b3 = new Bunny(name: "Bo", likesCarrots: true);

public class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny()
    {
    }

    public Bunny(string n)
    {
        Name = n;
    }

    public Bunny(string name, bool likesCarrots = false, bool likesHumans = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
}