// The this reference refers to the instance itself:

new Panda().Marry(new Panda());

public class Panda
{
	public Panda Mate;

	public void Marry(Panda partner)
	{
		Mate = partner;
		partner.Mate = this;
	}
}